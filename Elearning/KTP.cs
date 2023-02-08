using Microsoft.VisualBasic;
using System;

public class KTP {
    private Paragraph paragraph;
    private LessonType lessonType;
    private List<Content> listcontent;
    private int nomer;
    private int chas;
    public KTP(Paragraph paragraph, LessonType lessonType, List<Content> listcontent, int nomer, int chas)
    {
        this.paragraph = paragraph;
        this.lessonType = lessonType;
        this.listcontent = listcontent;
        this.nomer = nomer;
        this.chas = chas;
    }
}
