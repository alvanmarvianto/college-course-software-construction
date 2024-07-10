using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_1302223074
{
    internal class UIConfig
    {
        public UIConfig()
        {
            try
            {
                ReadConfig();
            }
            catch
            {
                SetDefault();
                WriteConfig();
            }
        }
        public BankTransferConfig bankConfig;
        public void ReadConfig()
        {
            string text = File.ReadAllText("D:\\Alvan\\kliah\\sem4\\kpl\\praktikum\\modul8_1302223074\\modul8_1302223074\\bank_transfer_config.json");
            bankConfig = JsonSerializer.Deserialize<BankTransferConfig>(text);
        }
        public void WriteConfig()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(bankConfig, options);
            File.WriteAllText("D:\\Alvan\\kliah\\sem4\\kpl\\praktikum\\modul8_1302223074\\modul8_1302223074\\bank_transfer_config.json", jsonString);
        }
        public void SetDefault()
        {
            List<string> method = new List<string> { "RTO(real - time)", "SKN", "RTGS", "BI FAST" };
            bankConfig = new BankTransferConfig ("en", 25000000, 6500, 15000, method, "yes", "ya");
        }
        public void ChangeLang()
        {
            if (bankConfig.lang == "en")
            {
                bankConfig.lang = "id";
                WriteConfig();
            } else
            {
                bankConfig.lang = "en";
                WriteConfig();
            }
        }
    }
}
