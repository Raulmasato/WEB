using ElectroJoule.Web.Models;
using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Preference;

namespace ElectroJoule.Web.Services;

public class MercadoPagoService
{
    private readonly IConfiguration _config;
    private readonly ILogger<MercadoPagoService> _logger;

    public MercadoPagoService(IConfiguration config, ILogger<MercadoPagoService> logger)
    {
        _config = config;
        _logger = logger;
        MercadoPagoConfig.AccessToken = _config["MercadoPago:AccessToken"]!;
    }

    public async Task<(string? InitPoint, string? Error)> CrearPreferenciaAsync(
        CheckoutViewModel checkout, string baseUrl)
    {
        try
        {
            var items = checkout.Carrito.Items.Select(i => new PreferenceItemRequest
            {
                Title = i.Nombre,
                Quantity = i.Cantidad,
                UnitPrice = i.PrecioUnit,
                CurrencyId = "ARS",
            }).ToList();

            var request = new PreferenceRequest
            {
                Items = items,
                Payer = new PreferencePayerRequest
                {
                    Name = checkout.Nombre,
                    Email = checkout.Email,
                    Phone = new PhoneRequest { Number = checkout.Telefono },
                    Identification = new IdentificationRequest { Type = "DNI", Number = checkout.Dni },
                },
                BackUrls = new PreferenceBackUrlsRequest
                {
                    Success = $"{baseUrl}/Pago/Exito",
                    Failure = $"{baseUrl}/Pago/Error",
                    Pending = $"{baseUrl}/Pago/Pendiente",
                },
                AutoReturn = "approved",
                StatementDescriptor = "ElectroJoule",
                ExternalReference = Guid.NewGuid().ToString("N"),
            };

            var client = new PreferenceClient();
            Preference preference = await client.CreateAsync(request);
            return (preference.InitPoint, null);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al crear preferencia en Mercado Pago");
            return (null, ex.Message);
        }
    }
}
