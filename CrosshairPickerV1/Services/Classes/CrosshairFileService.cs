using CrosshairPickerV1.Crosshairs;
using CrosshairPickerV1.Models;
using CrosshairPickerV1.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CrosshairPickerV1.Services.Classes
{
    public class CrosshairFileService : ICrosshairFileService
    {
        private string _filePath;
        private ColorFileData _crosshair;
        public CrosshairFileService(string filePath)
        {
            _filePath = Path.Combine(Environment.CurrentDirectory, filePath);
            if (!File.Exists(_filePath))
            {
                var fs = File.Create(_filePath);
                fs.Close();
            }
        }
        public async Task<ColorFileData?> GetCrosshairDataAsync()
        {
            try
            {
                var read = await File.ReadAllTextAsync(_filePath);
                _crosshair = JsonConvert.DeserializeObject<ColorFileData>(read) ?? new ColorFileData();
                return _crosshair;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<bool> WriteCrosshairDataAsync(ColorFileData crosshair)
        {
            try
            {
                _crosshair = crosshair;
                var serializer = JsonConvert.SerializeObject(crosshair);
                await File.WriteAllTextAsync(_filePath, serializer);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
