# Configuración ElectroJoule.Web

## Mercado Pago

1. Crear cuenta en https://www.mercadopago.com.ar/developers
2. Ir a **Credenciales** → **Credenciales de prueba** (para testing)
3. Copiar **Access Token** y **Public Key**
4. Editar `appsettings.json`:

```json
"MercadoPago": {
  "AccessToken": "TEST-xxxx-tu-access-token-xxxx",
  "PublicKey": "TEST-xxxx-tu-public-key-xxxx"
}
```

Para producción usar las credenciales productivas y cambiar `TEST-` por `APP_USR-`.

## Ejecutar

```bash
cd ElectroJoule.Web
dotnet run
```

Abrir https://localhost:5001
