# TOS_data_mining
Using TD Bank's Think or Swim API to mine independent variable data on stocks both the S&amp;P 500 and the Nasdaq 100 

This code was adapted from brtnsmth's (https://github.com/brtnsmth) 2019 Visual Basics code.

Here is a link to their GitHub repository: https://github.com/brtnsmth/TOS-RTD-core 

This project uses brtnsmth's starter code, which gathers 3-second interval data from various indicators and stocks found in TD Ameritrade's Think Or Swim(TOS) trading platform. brtnsmth uses Visual Basics to export livestreamed data from TOS to excel in 3 second intervals, then write each row into a .csv file. 

brtnsmth's published edition includes 21 columns.

1. Date
2. /ES Last
3. /NQ Last
4. /RTY Last
5. SPY Last
6. QQQ Last
7. IWM Last
8. AAPL Last
9. MSFT Last
10. NVDA Last
11. XLK Last
12. XLF Last
13. XLP Last
14. XLY Last
15. XTN Last
16. HYG Last
17. col 16
18. col 17
19. col 18
20. col 19
21. col 20

This project has adapted the code to include a total of 11462 columns.

The columns are derived from the unique stocks in the S&P500 plus the Nasdaq100; a total of 521 unique stocks.

The columns are also derived from the following 22 indicators: MARK, LAST, LAST_SIZE, BID_SIZE, BID, ASK, ASK_SIZE, NET_CHANGE, PERCENT_CHANGE, MARK_PERCENT_CHANGE, PUT_CALL_RATIO, CALL_VOLUME_INDEX, PUT_VOLUME_INDEX, OPTION_VOLUME_INDEX, BACK_EX_MOVE, FRONT_EX_MOVE, EX_MOVE_DIFF, IMPL_VOL, Spreads, MRKT_MKR_MOVE, MarketSentiment, VOLUME.

These indicators were thoughtfully selected. Think Or Swim's platform offers 100s of indicators. The indicators included in this project were selected because they are thought to be indepent variables. We don't want redundant information that will slow down our programs and take up too much space on our harddrive. 

We will seek to update these indicators as well, since this is the first iteration of this project. After some time, and possibly after we implement our neural networks trading algorithm on this data, I hypothesize that we will be able to cut out even more indicators. We need our future algorithm's performance to help us determine which of the above to keep. And we may also spend some time going back through TOS's indicators and to ensure that we haven't missed any other primary variables.

Examples of indicators that were omitted include VWAP, SMA, EMA, MACD, and Bollinger Bands, since we will be able to derive these indicators from the indepent variables that we are gathering with this program. 

Given 521 unique symbols in the S&P500 union the Nasdaq100.

Given 22 unique indicators from TOS.

521 x 22 = 11462

We will, of course, use iteration to generate these 11462 columns. We need 7 different lists of these 11462 elements. Each list we will copy and paste into the Visual Basics code developed by brtnsmth, in place of the 21 columns brtnsmth includes in their public edition. 

Let's take a look at the data that we need to make. (see 'data_to_make.vb')




TO-DO: 
We have all calls properly made. 
Paste each element in the right place. Make sure the format at the end is ok.
    - In the future I want to remove the issue with having to copy and paste all those new columns and rows in the right place.
        - It is not that hard to do if you know what you are doing... but it is weird if not.
        - I want the end goal to be a website where people can select their stock(s) and indicator(s) and being to write data onto their workspace.


First app:
App will allow users to pick a window of time.
Users select from a dropdown a stock in S&P or NQ they want to see.
We show them the 3 second interval data for that stock at that particular time. All columns.

Then we graph some of the columns. (price)...

Also, we should allow the user to choose which stock they want to use this program to gather independent variables.


Add clear instructions as to how to use this application, which tools are required to do so.