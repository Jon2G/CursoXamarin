using ListaAsistencia.Fonts;
using Xamarin.Forms;

[assembly: ExportFont("fa-brands-400.ttf", Alias = FontAwesome.Brands)]
[assembly: ExportFont("fa-regular-400.ttf", Alias = FontAwesome.Regular)]
[assembly: ExportFont("fa-solid-900.ttf", Alias = FontAwesome.Solid)]
namespace ListaAsistencia.Fonts
{
    public class FontAwesome
    {
        public const string Brands = "FA_BRAND";
        public const string Regular = "FA_REGULAR";
        public const string Solid = "FA_SOLID";

        public const string UserPlus = "";
        public const string CirclePlus = "";
        public const string Camera = "";
        public const string Pencil = "";
        public const string Trash = "";
    }
}
