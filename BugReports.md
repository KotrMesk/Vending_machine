1. Incorrect formating of total amount after purchase
    1. Summary: after buying twix, chocolate or brownie, the total amount displays the correct sum but incorrect format
    2. Environment: 
        Operating System: Windows 11 Home
        Browser: Google Chorme, Version 115.0.5790.171
        URL: file:///C:/Users/varna/Desktop/vending%20machine/index.html
      3. Steps to reproduce:
        a. Insert valid number in five euro field
        b. Insert valid number in two euro field
        c. Insert valid number in one euro field
        d. Insert valid number in ten cents field
        e. Press Twix button (or chocolate, or brownie)
    4. Expected results: Message appears: "Twix has been bought. €{amount} returned." and total amount message "0.00"
    5. Actual results: Message appears: "Twix has been bought. €{amount} returned." and total amount message "0"
2. Incorrect total amount after purchasing item with not enough money
    1. Summary: after trying to buy item with less money then required, wrong total amount is displayed
    2. Environment: 
        Operating System: Windows 11 Home
        Browser: Google Chorme, Version 115.0.5790.171
        URL: file:///C:/Users/varna/Desktop/vending%20machine/index.html
      3. Steps to reproduce:
        a. Insert 1 number in ten cents field
        b. Press Twix button (or chocolate, or brownie)
    4. Expected results: Message appears: "You have not paid enough. €0.00 has been returned." and total amount message stays the same as inputed before buying
    5. Actual results: Message appears: "You have not paid enough. €0.00 has been returned." and total amount message "0"
3. Unable to buy item with exact amount of money
    1. Summary: Unable to buy item with 2 euros inserted in vending machine.
    2. Environment: 
        Operating System: Windows 11 Home
        Browser: Google Chorme, Version 115.0.5790.171
        URL: file:///C:/Users/varna/Desktop/vending%20machine/index.html
      3. Steps to reproduce:
        a. Insert 1 number in two euros field
        b. Press Twix button (or chocolate, or brownie)
    4. Expected results: Message appears: "Brownie has been bought. €0.00 returned." and total amount message "0.00"
    5. Actual results: Message appears: "Please insert the right amount of money" and total amount message "2.00".
4. Incorrect total amount left after cancelling order
    1. Summary: once any amount is inserted in money field and canceled, total amount is not changed
    2. Environment: 
        Operating System: Windows 11 Home
        Browser: Google Chorme, Version 115.0.5790.171
        URL: file:///C:/Users/varna/Desktop/vending%20machine/index.html
      3. Steps to reproduce:
        a. Insert valid number in five euro field
        b. Insert valid number in two euro field
        c. Insert valid number in one euro field
        d. Insert valid number in ten cents field
        e. Press cancel button
    4. Expected results: Message appears: "First of all, you need to insert your money" and total amount message "0.00"
    5. Actual results: Message appears: "First of all, you need to insert your money" and total amount message was not changed, stayed the same after inputing all money denominations.
