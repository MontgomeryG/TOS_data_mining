' Most of the following code was copied directly from brtnsmth's published work.
' The following includes the 7 lists that we need to generate for the 11,000+ elements.
' Each list needs to be formatted in a way such that we can simply select all elements,
' then copy and paste them into brtnsmth's 'TOS import core Form1.vb'


' 1
' Defining Excel source cells
Private XL_Cell_1, XL_Cell_2, XL_Cell_3, XL_Cell_4, XL_Cell_5 As Excel.Range
Private XL_Cell_6, XL_Cell_7, XL_Cell_8, XL_Cell_9, XL_Cell_10 As Excel.Range
' ...
Private XL_Cell_6, XL_Cell_7, XL_Cell_8, XL_Cell_9, XL_Cell_LAST As Excel.Range


' 2
' Define DB output columns
Private Data_Col_1, Data_Col_2, Data_Col_3, Data_Col_4, Data_Col_5 As String
Private Data_Col_6, Data_Col_7, Data_Col_8, Data_Col_9, Data_Col_10 As String
' ....



' 3
' column headers written at file creation
Private strCSV_Header As String = "Date" & ", " & "/ES" & "AAPL Last" & "," &...& "AAPL Volume" & "," & "QQQ Last" &.& "lastTICKER + indicator"



' 4
' Define Cell Ranges
XL_Cell_1 = oSheet.Cells(1, 1)
XL_Cell_2 = oSheet.Cells(2, 1)
XL_Cell_3 = oSheet.Cells(3, 1)
' ...
XL_Cell_LAST = oSheet.Cells(LAST, 1)



' 5
' Now we get the excel formulas that call on the tos api. We could copy the rows from TOS live streaming data, and then click "export to Excel". 
' When we export, the formulas will be copied to our clipboard, and when we paste them into Excel they will update with the live market.
' Define Cell Formulas
XL_Cell_1.Formula = "=RTD(""tos.rtd"", , ""LAST"", ""QQQ"" )"
XL_Cell_2.Formula = "=RTD(""tos.rtd"", , ""LAST"", ""AAPL"" )"
XL_Cell_3.Formula = "=RTD(""tos.rtd"", , ""BID"", ""AAPL"" )"
' ...
XL_Cell_LAST.Formula = "=RTD(""tos.rtd"", , ""INDICATOR"", ""TICKER"" )"
XL_Cell_LAST.Formula = "=RTD(""tos.rtd"", , ""INDICATOR2"", ""TICKER2"" )"
' ...



' 6
' Now we are getting the data from the temp Excel file we are putting the data onto
' We are saving those data columns and then we will 
Data_Col_1 = CStr(XL_Cell_1.Value)
Data_Col_2 = CStr(XL_Cell_2.Value)
' ...
Data_Col_LAST = CStr(XL_Cell_LAST.Value)



' 7
' Building data string
strCSV_Data = CStr(tsTimeStamp) & ", " & Data_Col_1 & ", " & Data_Col_2 & ", " & Data_Col_3 & ... & ", " & Data_Col_LAST

' The idea is that I am capturing only the columns that update, and not indicators, but rather ratios of the independent variables being generated continuously

' Columns I want: Symbol, Mark, Theoretical Price, Last, Last Size, Bid Size, Bid, Ask, Ask Size, Net Change, %Change, Mark % Change, P/C Ratio,
' Call Sizzle Index, Put Sizzle Index, Sizzle Index, Back Expected Move, Front Expected Move, Expected Move Diff,  Implied Volatility, Spreads
' Market Maker Move, MarketSentiment, Volume

' Let's begin. (goto RTD_calls_formulation.ipynb)