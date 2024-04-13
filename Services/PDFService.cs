using Microsoft.Win32;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStation14_EventCardCreator.Services
{
    public static class PDFService
    {
        public static void SaveFile(int ev) 
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = $"{SaveLoadService.E_list[ev].MainProperties.EventName}";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font1 = new XFont("Bookman Old Style", 12, XFontStyle.Bold);
            XFont font2 = new XFont("Bookman Old Style", 12, XFontStyle.Regular);
            XFont font3 = new XFont("Bookman Old Style", 10, XFontStyle.Regular);
            XTextFormatter tf = new XTextFormatter(gfx);
            //
            gfx.DrawImage(XImage.FromStream(ImageService.PutImage(Properties.Resources.space_ss14)), 3, 3, 589, 835);
            //
            gfx.DrawRectangle(new XPen(XColor.FromKnownColor(XKnownColor.White)), new XRect(5, 5, 375, 200)); // основное поле
            gfx.DrawRectangle(new XPen(XColor.FromKnownColor(XKnownColor.White)), new XRect(5, 5, 375, 50)); // основные параметры
            gfx.DrawRectangle(new XPen(XColor.FromKnownColor(XKnownColor.White)), new XRect(385, 5, 200, 200)); // фото
            gfx.DrawRectangle(new XPen(XColor.FromKnownColor(XKnownColor.White)), new XRect(5, 210, 580, 300)); // описание 
            gfx.DrawRectangle(new XPen(XColor.FromKnownColor(XKnownColor.White)), new XRect(5, 210, 580, 100)); // свойства
            gfx.DrawRectangle(new XPen(XColor.FromKnownColor(XKnownColor.White)), new XRect(5, 530, 580, 300)); // схема
            //
            gfx.DrawString("Название: ", font1, XBrushes.White, new XRect(10, 5, 100, 12), XStringFormats.TopLeft);
            gfx.DrawString("Дата создания: ", font1, XBrushes.White, new XRect(10, 20, 100, 12), XStringFormats.TopLeft);
            gfx.DrawString("Автор: ", font1, XBrushes.White, new XRect(10, 35, 100, 12), XStringFormats.TopLeft);
            gfx.DrawString("Оценка: ", font1, XBrushes.White, new XRect(210, 35, 100, 12), XStringFormats.TopLeft);
            gfx.DrawString("Краткое описание: ", font1, XBrushes.White, new XRect(10, 60, 100, 12), XStringFormats.TopLeft);
            gfx.DrawString("Описание: ", font1, XBrushes.White, new XRect(10, 315, 100, 12), XStringFormats.TopLeft);
            //
            string s = "";
            for (int i = 0; i < SaveLoadService.E_list[ev].Properties.Count; i++) 
            {
                s += $"{SaveLoadService.E_list[ev].Properties[i].Name}: {SaveLoadService.E_list[ev].Properties[i].Value}, ";
            }
            s = s.Substring(0, s.Length - 2);
            tf.DrawString(s, font3, XBrushes.White, new XRect(10, 215, 560, 100), XStringFormats.TopLeft);
            gfx.DrawString($"{SaveLoadService.E_list[ev].MainProperties.EventName}", font2, XBrushes.White, new XRect(80, 5, 100, 12), XStringFormats.TopLeft);
            gfx.DrawString($"{SaveLoadService.E_list[ev].MainProperties.CreateDate}", font2, XBrushes.White, new XRect(115, 20, 100, 12), XStringFormats.TopLeft);
            gfx.DrawString($"{SaveLoadService.E_list[ev].MainProperties.Author}", font2, XBrushes.White, new XRect(55, 35, 100, 12), XStringFormats.TopLeft);
            gfx.DrawString($"{SaveLoadService.E_list[ev].MainProperties.Score} из 10", font2, XBrushes.White, new XRect(265, 35, 100, 12), XStringFormats.TopLeft);
            tf.DrawString($"{SaveLoadService.E_list[ev].MainProperties.ShortDescription}", font3, XBrushes.White, new XRect(10, 75, 370, 130), XStringFormats.TopLeft);
            tf.DrawString($"{SaveLoadService.E_list[ev].MainProperties.Description}", font3, XBrushes.White, new XRect(10, 330, 560, 180), XStringFormats.TopLeft);
            // отредактировать так чтоб был перенос
            // поработать с границами и еррор файлом
            if (SaveLoadService.E_list[ev].MainProperties.Photo != "error") 
            {
                gfx.DrawImage(XImage.FromStream(ImageService.UnwrapImage(SaveLoadService.E_list[ev].MainProperties.Photo)), 386, 6, 198, 198);
            }
            else 
            {
                gfx.DrawImage(XImage.FromStream(ImageService.PutImage(Properties.Resources.ss14_фон)), 386, 6, 198, 198);
            }
            if (SaveLoadService.E_list[ev].MainProperties.Scheme != "error")
            {
                gfx.DrawImage(XImage.FromStream(ImageService.UnwrapImage(SaveLoadService.E_list[ev].MainProperties.Scheme)), 6, 531, 578, 298);
            }
            document.Save(SaveLoadService.FileName.Substring(0, SaveLoadService.FileName.LastIndexOf("\\")) +$"\\Ивент_{SaveLoadService.E_list[ev].MainProperties.EventName}.pdf");
        }
    }
}
