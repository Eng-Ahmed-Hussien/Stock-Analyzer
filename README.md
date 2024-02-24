# Stock-Analyzer

## Problem Statement
This program is designed to allow users to input stock information, set a threshold stock price, and define an alert triggered if a predefined change of price is within a certain percentage .

## Requirements
- **Define a class Stock which contains Price and Symbol properties. It also contains an event PriceChanged which implements the standard in event handling and reports price change.**
- **Create a StockAnalyzer class which adds subscriptions to stocks with Price above a PriceThreshold so that when price changes around a ChangePercentThreshold an alert is triggered. This alert states if the price has increased or decreased and by how much from original price.**
- **To test these classes an open collection of stocks are inserted via standard input until the user inserts "!".**
- **Afterwards, both PriceThreshold and ChangePercentThreshold are received from the user.**
- **The StockAnalyzer is then ready to setup alerts.**
- **Finally, all stocks are updated with new prices and alerts are triggered accordingly.**

## Important Notes :
- Make sure to use LINQ to filter the stocks
- Only class names must be the same as stated in the requirements, all other members are suggested named and you can choose another suitable name.
- Any number inserted is checked and if it cannot be parsed the prompt will be shown again until a proper number is inserted.
- All numbers shown has only two decimal places after the decimal point.
- If you build a generic method that can receive a prompt to show to the user and can parse the input number from standard input and assign it to whichever - repeating the prompt if the input is incorrect - you will get 5 bonus degrees in this assignment. (Hint: you must use a generic constraint so that only numbers are acceptable)

### Sample Run 1
- ***Enter stock data (symbol, price) or type '!' to finish:***
- ***Enter stock symbol:*** MSFT
- ***Enter stock initial price:***
    - 100
- ***Enter stock symbol:*** APPL
- ***Enter stock initial price:***
   - 200
- ***Enter stock symbol:*** !
- ***Enter a threshold price to monitor for change:***
 - 150
- ***Enter a threshold price change percent:***
   - 4
- ***For stock with symbol MSFT, Please enter the new price:***
    - 900
- ***For stock with symbol APPL, Please enter the new price:***
    - 800
    - **Alert !. Price increased by 300 %**

### Sample Run 2
- ***Enter stock data (symbol, price) or type '!' to finish:***
- ***Enter stock symbol:*** TSLA
- ***Enter stock TSLA initial price:***
    - 256.11
- ***Enter stock symbol:*** AMD
- ***Enter stock AMD initial price:***
    - 139.60
- ***Enter stock symbol:*** INTC
- ***Enter stock INTC initial price:***
    - 48.13
- ***Enter stock symbol:*** AMZN
- ***Enter stock AMZN initial price:***
    - 153.67
- ***Enter stock symbol:*** !
- ***Enter a threshold price to monitor for change:***
    - 150
- ***Enter a threshold price change percent:***
    - !#$#
- ***Enter a threshold price change percent:***
    - 3
- ***For stock with symbol TSLA, Please enter the new price:***
    - 210.87
    - **Alert !. Price decreased by -17.66 %**
- ***For stock with symbol AMD, Please enter the new price:***
    - ????
- ***For stock with symbol AMD, Please enter the new price:***
    - 170
- ***For stock with symbol INTC, Please enter the new price:***
    - 80
- ***For stock with symbol AMZN, Please enter the new price:***
    - 190
    - **Alert !. Price increased by 23.64 %**
