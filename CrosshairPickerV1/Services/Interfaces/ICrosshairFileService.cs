using CrosshairPickerV1.Crosshairs;
using CrosshairPickerV1.Models;

namespace CrosshairPickerV1.Services.Interfaces
{
    public interface ICrosshairFileService
    {
        Task<ColorFileData?> GetCrosshairDataAsync();
        Task<bool> WriteCrosshairDataAsync(ColorFileData crosshair);
    }
}