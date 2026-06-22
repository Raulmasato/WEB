using ElectroJoule.Web.Models;

namespace ElectroJoule.Web.Services;

public class ProductoService
{
    private readonly List<Producto> _productos = new()
    {
        new() {
            Id = 1, Slug = "arduino-uno-r3",
            Nombre = "Arduino Uno R3",
            Descripcion = "Microcontrolador ATmega328P, 14 pines digitales, 6 analógicos, 32KB Flash. Ideal para proyectos de electrónica y robótica. Compatible con shields y miles de librerías.",
            Precio = 8500, Stock = 45,
            Categoria = "Microcontroladores", Marca = "Arduino",
            ImagenUrl = "https://placehold.co/480x340/1a1a2e/white?text=Arduino+Uno+R3&font=montserrat"
        },
        new() {
            Id = 2, Slug = "esp32-devkit-v1",
            Nombre = "ESP32 DevKit V1",
            Descripcion = "Módulo Wi-Fi + Bluetooth dual-core 240MHz. 4MB Flash, 38 GPIOs. Perfecto para IoT, domótica y proyectos conectados. Incluye conector USB-Micro.",
            Precio = 3200, Stock = 80,
            Categoria = "Microcontroladores", Marca = "Espressif",
            ImagenUrl = "https://placehold.co/480x340/0f3460/white?text=ESP32+DevKit&font=montserrat"
        },
        new() {
            Id = 3, Slug = "raspberry-pi-4-2gb",
            Nombre = "Raspberry Pi 4 Model B 2GB",
            Descripcion = "Computadora de placa única con procesador Cortex-A72 1.8GHz, 2GB RAM LPDDR4. Puertos USB 3.0, HDMI dual 4K, Wi-Fi ac, Bluetooth 5.0, Gigabit Ethernet.",
            Precio = 52000, Stock = 12,
            Categoria = "Computadoras SBC", Marca = "Raspberry Pi",
            ImagenUrl = "https://placehold.co/480x340/e94560/white?text=Raspberry+Pi+4&font=montserrat"
        },
        new() {
            Id = 4, Slug = "sensor-dht22",
            Nombre = "Sensor DHT22 Temperatura y Humedad",
            Descripcion = "Sensor digital de temperatura (-40°C a +80°C, ±0.5°C) y humedad (0–100% HR, ±2%). Protocolo 1-Wire, ideal para estaciones meteorológicas y sistemas de climatización.",
            Precio = 1200, Stock = 120,
            Categoria = "Sensores", Marca = "Aosong",
            ImagenUrl = "https://placehold.co/480x340/533483/white?text=Sensor+DHT22&font=montserrat"
        },
        new() {
            Id = 5, Slug = "modulo-l298n",
            Nombre = "Módulo L298N Puente H Doble",
            Descripcion = "Driver de motores DC y PAP. Control de 2 motores DC o 1 motor PAP. Voltaje de motor 5–35V, corriente 2A por canal. Incluye regulador 5V integrado.",
            Precio = 1800, Stock = 60,
            Categoria = "Drivers y Módulos", Marca = "Genérico",
            ImagenUrl = "https://placehold.co/480x340/2d6a4f/white?text=Puente+H+L298N&font=montserrat"
        },
        new() {
            Id = 6, Slug = "pantalla-oled-096",
            Nombre = "Pantalla OLED 0.96\" I2C 128x64",
            Descripcion = "Display OLED monocromático 128×64 píxeles, interfaz I2C (SDA/SCL). Controlador SSD1306. Librería compatible con Arduino, ESP32 y MicroPython. Ángulo de visión 160°.",
            Precio = 1500, Stock = 75,
            Categoria = "Displays", Marca = "Genérico",
            ImagenUrl = "https://placehold.co/480x340/1b4332/white?text=OLED+0.96+I2C&font=montserrat"
        },
        new() {
            Id = 7, Slug = "relay-5v-pack2",
            Nombre = "Módulo Relay 5V (pack x2)",
            Descripcion = "Módulo de 2 relés con transistor de aislamiento. Carga máx: 250V AC / 10A, 30V DC / 10A. Control por señal 3.3V–5V. Incluye terminales de tornillo para conexión de carga.",
            Precio = 650, Stock = 200,
            Categoria = "Drivers y Módulos", Marca = "SunFounder",
            ImagenUrl = "https://placehold.co/480x340/d62828/white?text=Relay+5V+x2&font=montserrat"
        },
        new() {
            Id = 8, Slug = "resistencias-10k-x100",
            Nombre = "Resistencias 10kΩ 1/4W (pack x100)",
            Descripcion = "Resistencias de carbono 10kΩ, tolerancia 5%, potencia 1/4W. Presentación en tira de 100 unidades. Banda de colores café-negro-naranja. Ideales para pull-up y divisores de tensión.",
            Precio = 450, Stock = 500,
            Categoria = "Componentes Pasivos", Marca = "Yageo",
            ImagenUrl = "https://placehold.co/480x340/6a4c93/white?text=Resistencias+10k+x100&font=montserrat"
        },
        new() {
            Id = 9, Slug = "led-rgb-5mm-x10",
            Nombre = "LED RGB 5mm Cátodo Común (pack x10)",
            Descripcion = "LEDs RGB de 5mm, cátodo común. Diámetro de lente claro. Longitud de onda: R=625nm, G=525nm, B=465nm. Corriente nominal 20mA por canal. Ángulo de visión 30°.",
            Precio = 280, Stock = 800,
            Categoria = "LEDs y Iluminación", Marca = "Genérico",
            ImagenUrl = "https://placehold.co/480x340/f77f00/white?text=LED+RGB+x10&font=montserrat"
        },
        new() {
            Id = 10, Slug = "capacitor-100uf-x20",
            Nombre = "Capacitor Electrolítico 100µF 25V (x20)",
            Descripcion = "Capacitores electrolíticos 100µF 25V, paso 2mm. Temperatura de operación -40°C a +85°C. Vida útil 2000h a 85°C. Polaridad marcada. Pack de 20 unidades.",
            Precio = 380, Stock = 600,
            Categoria = "Componentes Pasivos", Marca = "Nichicon",
            ImagenUrl = "https://placehold.co/480x340/4a4e69/white?text=Cap+100uF+x20&font=montserrat"
        },
        new() {
            Id = 11, Slug = "sensor-hc-sr04",
            Nombre = "Sensor Ultrasónico HC-SR04",
            Descripcion = "Sensor de distancia por ultrasonido. Rango: 2cm–400cm, resolución 3mm. Alimentación 5V, corriente 15mA. Pines: VCC, Trig, Echo, GND. Frecuencia: 40kHz.",
            Precio = 750, Stock = 150,
            Categoria = "Sensores", Marca = "HC-SR",
            ImagenUrl = "https://placehold.co/480x340/023e8a/white?text=HC-SR04+Ultrasónico&font=montserrat"
        },
        new() {
            Id = 12, Slug = "protoboard-830-puntos",
            Nombre = "Protoboard 830 Puntos + Cables Dupont",
            Descripcion = "Protoboard de 830 puntos de contacto sin soldadura. Incluye kit de 65 cables Dupont (M-M, M-H, H-H). Riel de alimentación doble. Compatible con componentes DIP estándar.",
            Precio = 1100, Stock = 90,
            Categoria = "Herramientas y Accesorios", Marca = "Genérico",
            ImagenUrl = "https://placehold.co/480x340/2b9348/white?text=Protoboard+830&font=montserrat"
        },
    };

    public List<Producto> ObtenerTodos() => _productos;

    public List<Producto> Filtrar(FiltroProducto filtro)
    {
        var query = _productos.AsEnumerable();
        if (!string.IsNullOrWhiteSpace(filtro.Buscar))
            query = query.Where(p => p.Nombre.Contains(filtro.Buscar, StringComparison.OrdinalIgnoreCase)
                                  || p.Descripcion.Contains(filtro.Buscar, StringComparison.OrdinalIgnoreCase));
        if (!string.IsNullOrWhiteSpace(filtro.Categoria))
            query = query.Where(p => p.Categoria == filtro.Categoria);
        if (!string.IsNullOrWhiteSpace(filtro.Marca))
            query = query.Where(p => p.Marca == filtro.Marca);
        return query.ToList();
    }

    public Producto? ObtenerPorId(int id) => _productos.FirstOrDefault(p => p.Id == id);
    public Producto? ObtenerPorSlug(string slug) => _productos.FirstOrDefault(p => p.Slug == slug);
    public List<string> ObtenerCategorias() => _productos.Select(p => p.Categoria).Distinct().OrderBy(c => c).ToList();
    public List<string> ObtenerMarcas() => _productos.Select(p => p.Marca).Distinct().OrderBy(m => m).ToList();
}
