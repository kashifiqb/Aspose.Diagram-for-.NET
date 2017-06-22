﻿Imports Aspose.Diagram
Imports System
Public Class ReadSolutionXMLElement
    Public Shared Sub Run()
        ' ExStart:ReadSolutionXMLElement
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_SolutionXML()

        ' Load source Visio diagram
        Dim diagram As New Diagram(dataDir & Convert.ToString("Drawing1.vsdx"))

        ' Iterate through SolutionXML elements
        For Each solutionXML As SolutionXML In diagram.SolutionXMLs
            ' Get name property
            Console.WriteLine(solutionXML.Name)
            ' Get xml value
            Console.WriteLine(solutionXML.XmlValue)
        Next
        ' ExEnd:ReadSolutionXMLElement
    End Sub
End Class