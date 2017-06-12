using System.Linq;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ChannelRankings.Models;
using ChannelRankins.Contracts.Data;
using ChannelRankins.Contracts.Utils;

namespace ChannelRankings.Utils.Reporters
{
    public class PdfReporter : IPdfReporter
    {
        private ISqlServerDatabase database;
        private IRepository<Channel> channels;

        public PdfReporter(ISqlServerDatabase database, IRepository<Channel> channels)
        {
            this.database = database;
            this.channels = channels;
        }

        public void CreateReport(string savePath)
        {
            var leftRightMargin = 10;
            var topBottomMargin = 20;

            var document = new Document(PageSize.LETTER, leftRightMargin, leftRightMargin, topBottomMargin, topBottomMargin);
            var databaseChannels = this.channels.GetAll()
                .OrderByDescending(x => long.Parse(x.Corporation.Owner.NetWorth))
                .ToList();

            using (var fs = new FileStream(savePath, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(document, fs);

                document.Open();

                this.AddDocHeader(document);
                this.CreatePdfTable(document, databaseChannels);

                document.Close();
            }
        }

        private void CreatePdfTable(Document document, IEnumerable<Channel> channels)
        {
            var table = new PdfPTable(3);
            var headerCellColor = new BaseColor(214, 214, 214);
            var headerCellFontSize = 14.0f;
            table.DefaultCell.Padding = 10;

            var channelNameColumn = this.FormatHeaderCell("Channel Name", FontFactory.HELVETICA_BOLD, headerCellColor, headerCellFontSize);
            var ownerName = this.FormatHeaderCell("Owner name", FontFactory.HELVETICA_BOLD, headerCellColor, headerCellFontSize);
            var ownerNetWorth = this.FormatHeaderCell("Owner net worth", FontFactory.HELVETICA_BOLD, headerCellColor, headerCellFontSize);

            table.AddCell(channelNameColumn);
            table.AddCell(ownerName);
            table.AddCell(ownerNetWorth);

            foreach (var ch in channels)
            {
                table.AddCell(ch.Name);
                table.AddCell(ch.Corporation.Owner.FirstName + ' ' + ch.Corporation.Owner.LastName);
                table.AddCell("$ " + ch.Corporation.Owner.NetWorth);
            }

            document.Add(table);
        }

        private void AddDocHeader(Document document)
        {
            Image headerImage = Image.GetInstance("../../../../Data/Resources/tv-logo.png");
            headerImage.SetAbsolutePosition(15, document.PageSize.Height - 95);
            headerImage.ScaleAbsolute(70, 70);

            document.Add(headerImage);

            var titleText = "Top TV-Channels by owner net worth";
            var titleTable = new PdfPTable(numColumns: 1);
            var titleFontSize = 25.0f;

            var titleCell = this.FormatHeaderCell(titleText, FontFactory.HELVETICA_BOLD, BaseColor.WHITE, titleFontSize);
            titleCell.BorderColor = BaseColor.WHITE;
            titleTable.SpacingAfter = 30;

            titleTable.AddCell(titleCell);
            document.Add(titleTable);
        }

        private PdfPCell FormatHeaderCell(string text, string font, BaseColor color, float fontSize)
        {
            var formattedChunk = new Chunk(text, FontFactory.GetFont(font, fontSize));

            var pdfCell = new PdfPCell(new Phrase(formattedChunk));

            pdfCell.BackgroundColor = color;
            pdfCell.Padding = 10;
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;

            return pdfCell;
        }
    }
}
