﻿Imports Aspose.Diagram
Imports System
Public Class EditPageLevelCommentInVisio
    Public Shared Sub Run()
        ' ExStart:EditPageLevelCommentInVisio
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_VisioComments()

        ' Load Visio
        Dim diagram As New Diagram(dataDir & Convert.ToString("Drawing1.vsdx"))

        ' Get collection of the annotations
        Dim annotations As AnnotationCollection = diagram.Pages.GetPage("Page-1").PageSheet.Annotations

        ' Iterate through the annotations
        For Each annotation As Annotation In annotations
            Dim comment As String = annotation.Comment.Value
            comment += "Updation mark"
            annotation.Comment.Value = comment
        Next
        ' Save Visio
        diagram.Save(dataDir & Convert.ToString("EditComment_out.vsdx"), SaveFileFormat.VSDX)
        ' ExEnd:EditPageLevelCommentInVisio
    End Sub
End Class