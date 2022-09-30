using Pavel_Cosmin_Proiect_Paw_1056_D.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Database
{
    public class FakeDatabase
    {
        public static List<ComputerComponent> Components = new List<ComputerComponent>()
        {
            new ComputerComponent{
                ID = Guid.NewGuid(),
                Type = "Mouse",
                Name = "Wireless Mouse Cimetech",
                Brand = "Logitech",
                Description = "The wireless mouse with long battery life due to it come with smart auto sleep mode, when lower power consumption, the mouse will enter the automatic sleep state to save power if you don‘t use it for 8 minutes,then click mouse runs on again.",
                Price = 10.19
            },

            new ComputerComponent()
            {
                ID = Guid.NewGuid(),
                Type = "Mouse",
                Name = "USB Computer Mouse",
                Brand = "Macally", 
                Description = "The 3-button wired mouse measures 4.3 x 2.4x 1.35 with a 4.92 foot (1.5 meter) cable, work with Windows and Mac OS",
                Price = 6.94
            },

            new ComputerComponent()
            {
                ID= Guid.NewGuid(),
                Type = "Keyboard",
                Name = "Matte Black Wired Keyboard",
                Brand = "Amazon Basics",
                Description = "Simple Wired USB Connection; Works with Windows 2000, XP, Vista, 7, 8, and 10",
                Price = 13.63
            },

            new ComputerComponent()
            {
                ID = Guid.NewGuid(),
                Type = "Keyboard",
                Name = "Wireless Keyboard Stainless",
                Brand = "	Arteck",
                Description = "Ultra Thin and Light: Compact size (16.9 X 4.9 X 0.6in) and light weight (14.9oz) but provides full size keys, arrow keys, number pad, shortcuts for comfortable typing.",
                Price = 23.79
            },

            new ComputerComponent()
            {
                ID = Guid.NewGuid(),
                Type = "Monitor",
                Name = "SAMSUNG T350 Computer Monitor",
                Brand = "SAMSUNG",
                Description = "SEAMLESS, SMOOTH VISUALS: Now, the picture looks flawless. The 75Hz refresh rate delivers more fluid scenes. Whether you're catching up on your favorite TV drama, watching a video, or playing a game, your entertainment has no lag or ghosting effect",
                Price = 149.00
            },

            new ComputerComponent()
            {
                ID = Guid.NewGuid(),
                Type = "Monitor",
                Name = "ASUS TUF Gaming 32'' 1080P Curved Monitor",
                Brand = "ASUS",
                Description = "2-inch Full HD (1920 x 1080) 1500R curved gaming monitor with ultrafast 165Hz refresh rate designed for professional gamers and immersive gameplay",
                Price = 299.00
            },

            new ComputerComponent()
            {
                ID = Guid.NewGuid(),
                Type = "Desktop",
                Name = "HP Pavilion TP01 Desktop PC",
                Brand = "HP",
                Description = "Intel Core i7-11700F (2.5 GHz base frequency, up to 4.9 GHz with Intel Turbo Boost Technology, 16 MB L3 cache, 8 cores), 16GB memory; 1TB HDD, 256GB SSD",
                Price = 649.99
            },

            new ComputerComponent()
            {
                ID= Guid.NewGuid(),
                Type = "Desktop",
                Name = "Acer Predator Orion 3000 Gaming Desktop",
                Brand = "Acer",
                Description = "11th Generation Intel Core i7-11700F 8-Core Processor (Up to 4.9GHz), 16GB DDR4 3200MHz Memory (expandable to 64GB), 512GB NVMe M.2 SSD, 1TB 7200RPM HDD",
                Price = 1699.99
            },

            new ComputerComponent()
            {
                ID = Guid.NewGuid(),
                Type = "Processor",
                Name = "Intel Core i9-10900 Desktop Processor 10",
                Brand = "Intel",
                Description = "Intel Turbo Boost Max Technology 3.0 Support, up to 5.2 GHz, Cooler Included",
                Price = 389.97
            },

            new ComputerComponent()
            {
                ID = Guid.NewGuid(),
                Type = "Processor",
                Name = "Intel Core i7-10700F Desktop Processor 8",
                Brand = "Intel",
                Description = "Compatible with Intel 400 series chipset based motherboards, Socket Type LGA 1200",
                Price = 249.99
            },

            new ComputerComponent()
            {
                ID = Guid.NewGuid(),
                Type = "Drive",
                Name = "External DVD Drive USB 3.0, Burner Portable",
                Brand = "	Ziweo",
                Description = "The CD/DVD drive external USB 3.0 and USB-C ports and doesn't require an external driver or power supply.Just plug it into your laptop's USB and Type-C ports and the CD/DVD drive will be automatically detected.",
                Price = 23.89
            },

            new ComputerComponent()
            {
                ID = Guid.NewGuid(),
                Type = "Drive",
                Name = "External CD/DVD Drive Optical Reader Writer",
                Brand = "OOCLCURFUL",
                Description = "Usb CD/DVD Drive - DVD drive external usb, no need for external driver and power supply. Just plug the usb cd drive in the USB port and start to enjoy yourself",
                Price = 17.99
            }
        };

        public static List<ComputerComponent> CartShop = new List<ComputerComponent>();

        public static List<Client> Clients = new List<Client>();

        public static List<PaymentInvoice> Invoices = new List<PaymentInvoice>();
    }
}
