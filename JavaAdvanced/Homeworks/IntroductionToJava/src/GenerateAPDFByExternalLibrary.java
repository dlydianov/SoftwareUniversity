import com.itextpdf.text.*;
import com.itextpdf.text.Font;
import com.itextpdf.text.pdf.*;

import java.io.FileOutputStream;
import java.io.IOException;
import java.text.MessageFormat;


public class GenerateAPDFByExternalLibrary {
    public static void main(String[] args)
         throws DocumentException, IOException {

         String[] typeOfCards = { "\u2663", "\u2666","\u2665" ,"\u2660"};
         String[] cards = new String[13];
         fillingTheCardsArray(cards);
         formattingToPDF(cards, typeOfCards);
    }

    private static void formattingToPDF(String[] cards, String[] typeOfCards)
                                 throws  DocumentException, IOException {
        Document document = new Document();
        PdfWriter.getInstance(document, new FileOutputStream("generateCards.pdf"));
        document.open();
        printingTheCards(typeOfCards,cards, document);
        document.close();
    }


    private static void printingTheCards(String[] typeOfCards, String[] cards, Document document)
            throws DocumentException, IOException {
        PdfPTable table = new PdfPTable(4);
        BaseFont baseFont = BaseFont.createFont("c:/windows/fonts/arial.ttf", BaseFont.IDENTITY_H,true);
        Font redFont = new Font(baseFont,12f, 0, BaseColor.RED);
        Font blackFont = new Font(baseFont,12f, 0, BaseColor.BLACK);
        Font centralRedFont = new Font(baseFont,20f, 0, BaseColor.RED);
        Font centralBlackFont = new Font(baseFont,20f, 0, BaseColor.BLACK);
        Float heightOfCellsInsideCard = 35f;
        for (int i = 0; i < cards.length; i++) {
            for (int j = 0; j < 4; j++) {

                PdfPCell singleCardCell = new PdfPCell();
                singleCardCell.setBorder(Rectangle.NO_BORDER);
                singleCardCell.setPadding(3);
                PdfPCell insideCardCell = new PdfPCell();

                PdfPTable singleCardTable = new PdfPTable(1);
                PdfPTable insideCardTable = new PdfPTable(3);
                insideCardCell.setPadding(3f);
                insideCardCell.setPaddingBottom(3f);
                insideCardCell.setPaddingTop(3f);
                PdfPCell upperLeftCell;
                PdfPCell upperRightCell;
                PdfPCell centralCell;
                PdfPCell lowerLeftCell;
                PdfPCell lowerRightCell;
                if (j == 0 || j == 3) {
                    upperLeftCell= new PdfPCell(new Paragraph((cards[i] + typeOfCards[j]+ " "), blackFont));
                    upperRightCell= new PdfPCell(new Paragraph((cards[i] + typeOfCards[j]+ " "), blackFont));
                    lowerLeftCell= new PdfPCell(new Paragraph((cards[i] + typeOfCards[j]+ " "), blackFont));
                    lowerRightCell= new PdfPCell(new Paragraph((cards[i] + typeOfCards[j]+ " "), blackFont));
                    centralCell= new PdfPCell(new Paragraph(typeOfCards[j], centralBlackFont));
                } else{
                    upperLeftCell= new PdfPCell(new Paragraph((cards[i] + typeOfCards[j]+ " "), redFont));
                    upperRightCell= new PdfPCell(new Paragraph((cards[i] + typeOfCards[j] + " "), redFont));
                    lowerLeftCell= new PdfPCell(new Paragraph((cards[i] + typeOfCards[j]+ " "), redFont));
                    lowerRightCell= new PdfPCell(new Paragraph((cards[i] + typeOfCards[j]+ " "), redFont));
                    centralCell= new PdfPCell(new Paragraph(typeOfCards[j], centralRedFont));
                }
                PdfPCell emptyCell = new PdfPCell();
                emptyCell.setFixedHeight(heightOfCellsInsideCard);
                emptyCell.setBorder(Rectangle.NO_BORDER);

                PdfPCell centralEmptyCell = new PdfPCell();
                centralEmptyCell.setFixedHeight(heightOfCellsInsideCard - 5);
                centralEmptyCell.setBorder(Rectangle.NO_BORDER);

                upperLeftCell.setFixedHeight(heightOfCellsInsideCard);
                upperLeftCell.setHorizontalAlignment(Element.ALIGN_LEFT);
                upperLeftCell.setVerticalAlignment(Element.ALIGN_TOP);
                upperLeftCell.setBorder(Rectangle.NO_BORDER);

                upperRightCell.setFixedHeight(heightOfCellsInsideCard);
                upperRightCell.setHorizontalAlignment(Element.ALIGN_RIGHT);
                upperRightCell.setVerticalAlignment(Element.ALIGN_TOP);
                upperRightCell.setBorder(Rectangle.NO_BORDER);

                lowerLeftCell.setFixedHeight(heightOfCellsInsideCard);
                lowerLeftCell.setHorizontalAlignment(Element.ALIGN_LEFT);
                lowerLeftCell.setVerticalAlignment(Element.ALIGN_BOTTOM);
                lowerLeftCell.setPaddingBottom(5);
                lowerLeftCell.setBorder(Rectangle.NO_BORDER);

                lowerRightCell.setFixedHeight(heightOfCellsInsideCard);
                lowerRightCell.setHorizontalAlignment(Element.ALIGN_RIGHT);
                lowerRightCell.setVerticalAlignment(Element.ALIGN_BOTTOM);
                lowerRightCell.setPaddingBottom(5);
                lowerRightCell.setBorder(Rectangle.NO_BORDER);


                centralCell.setFixedHeight(heightOfCellsInsideCard - 5);
                centralCell.setHorizontalAlignment(Element.ALIGN_CENTER);
                centralCell.setVerticalAlignment(Element.ALIGN_CENTER);
                centralCell.setBorder(Rectangle.NO_BORDER);


                insideCardTable.addCell(upperLeftCell);
                insideCardTable.addCell(emptyCell);
                insideCardTable.addCell(upperRightCell);
                insideCardTable.completeRow();
                insideCardTable.addCell(centralEmptyCell);
                insideCardTable.addCell(centralCell);
                insideCardTable.addCell(centralEmptyCell);
                insideCardTable.completeRow();
                insideCardTable.addCell(lowerLeftCell);
                insideCardTable.addCell(emptyCell);
                insideCardTable.addCell(lowerRightCell);

                insideCardCell.addElement(insideCardTable);
                singleCardTable.addCell(insideCardCell);
                singleCardCell.addElement(singleCardTable);


                table.addCell(singleCardCell);
            }
        }
        document.add(table);
    }
    private static void fillingTheCardsArray(String[] cards) {
        Integer currentIndex = 0;
        for (int k = 2; k < 11; k++) {
            cards[currentIndex] = MessageFormat.format("{0}", k);
            currentIndex++;
        }
        cards[currentIndex] = "J";
        currentIndex++;
        cards[currentIndex] = "Q";
        currentIndex++;
        cards[currentIndex] = "K";
        currentIndex++;
        cards[currentIndex] = "A";
        currentIndex++;


    }
}
