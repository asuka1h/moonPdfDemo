### using moonPdfLib to preview pdf in C# (for me it is WPF) project. 

This library is simple and convenient. 
### install library: 
	- using nuget manager in visual studio
	open Solution Explorer, find the root of the project, right click it. 
	navigate to "manage Nuget packages...", in browse part, search for MoonPdfLib.Package-x86 by haokekang
	install it, then you are able to use it.
	- downloading ddl files manually:
	download three dlls: MoonPdfLib.dll、libmupdf.dll、MouseKeyboardActivityMonitor.dll. 
	put those file under the bin file of your project
	in Solution Explorer, right click on your project name and add new reference : MoonPdfLib.dll
### coding:
  - in XAML: 
    <Grid Name ="pdf_grid" Margin="0,135,0,0">
            <mpp:MoonPdfPanel x:Name="pdfPanel" 
            Background="LightGray" ViewType="SinglePage"  PageRowDisplay="ContinuousPageRows"
                PageMargin="0,2,4,2" AllowDrop="True" Grid.ColumnSpan="8" />
    </Grid>

  - in cs file:
    using MoonPdfLib;

    var filePath = @"D:\work\programRelated\视频\capsules.pdf";
    pdfPanel.OpenFile(filePath);

then we all done.  Enjoy your coding :)
