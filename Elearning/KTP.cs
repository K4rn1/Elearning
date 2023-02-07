using Microsoft.VisualBasic;
using System;

public class KTP {
    private Paragraph paragraph;
    private LessonType lessonType;
    private Content content;
    private int nomer;
    private int chas;
    public KTP(Paragraph paragraph, LessonType lessonType, Content content, int nomer, int chas)
    {
        this.paragraph = paragraph;
        this.lessonType = lessonType;
        this.content = content;
        this.nomer = nomer;
        this.chas = chas;
}
}
