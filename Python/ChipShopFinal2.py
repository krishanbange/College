import PySimpleGUI as sg #Imports from the PySimpleGUI file in the folder
import time

## Global varaibles

global orderitems
orderitems = "" # Used for receipt
global sanitycheck
sanitycheck = 0 # Used for order amount sanity check
global pricetotal
pricetotal = 0 # Price in final calculation - needs to be a float 
pricetotal = float(pricetotal)


itemlist = ['Small Fish and Chips', 'Large Fish and Chips', 'Steak and Kidney Pie', 'Steak and Kidney Pie with Chips', 'Sausage and Chips'] # Predefined item list for calculaton and receipt
itemlistspinner = ['Small Fish and Chipsbox', 'Large Fish and Chipsbox', 'Steak and Kidney Piebox', 'Steak and Kidney Pie with Chipsbox', 'Sausage and Chipsbox'] # List needed for a loop on receipt calculation
pricelist = [2.00, 4.60, 1.40, 2.45, 3.00] # Price calculation is needed

sg.theme('LightBlue') #This is how the colour theme of the interface is created
layout = [ [sg.Text('Welcome to Sea Front Fish Shop')], #Setup GUI
           [sg.Checkbox('Small fish and chips {£2.00}', key="Small Fish and Chips"), sg.Spin([i for i in range(0,99)], initial_value=0, disabled=True, size=(5,5),key="Small Fish and Chipsbox")],
           [sg.Checkbox('Large fish and chips {£4.60}', key="Large Fish and Chips"), sg.Spin([i for i in range(0,99)], initial_value=0, disabled=True, size=(5,5),key="Large Fish and Chipsbox")],
           [sg.Checkbox('Steak and Kidney Pie {£1.40}', key="Steak and Kidney Pie"), sg.Spin([i for i in range(0,99)], initial_value=0, disabled=True, size=(5,5),key="Steak and Kidney Piebox")],
           [sg.Checkbox('Steak and Kidney and Chips {£2.45}', key="Steak and Kidney Pie with Chips"), sg.Spin([i for i in range(0,99)], initial_value=0, disabled=True, size=(5,5),key="Steak and Kidney Pie with Chipsbox")],
           [sg.Checkbox('Regular Sausage and Chips {£3.00}', key="Sausage and Chips"), sg.Spin([i for i in range(0,99)], initial_value=0, disabled=True, size=(5,5),key="Sausage and Chipsbox")],
           [sg.Text('Would you like any sauces? {£0.40}'), sg.Combo(['Curry Sauce', 'Mushy Peas', 'Gravy', 'Ketchup', 'Mayo', 'No Sauce'], key="sauceitem", size=(11,5))],
           [sg.Text('How would you like to pay?'), sg.Combo(['Cash', 'Card'], size=(6,5), key='cashrcard')],
           [sg.Text('Would you like to eat in or take-away? {£0.10}'), sg.Combo(['Eat in {£0.10}', 'Take-Away {Free}'], key="inrout")],
           [sg.Text('Name: '),sg.InputText(key="nameofp")],
           [sg.Ok(), sg.Cancel()]]
window = sg.Window('OrderMenu', layout)

while True:             
    event, values = window.read(timeout=10)
    if event in (None, 'Cancel'):
        break

    for checkiftrue in itemlist:
        try:
            if values[checkiftrue] == True:
                window.FindElement(checkiftrue + 'box').Update(disabled=False)
            else:
                window.FindElement(checkiftrue + 'box').Update(disabled=True)
                window.FindElement(checkiftrue + 'box').Update(disabled=True, value=0)  #If the check box is ticked then the spinner is enabled, if not it is disabled
        except:
            pass

    if event in (None, 'Ok'):
                 orderlayout = [
                        [sg.Text("Your order is: ")],
                        [sg.Multiline("None", key="orderfinal", size=(70,25))], #If user clicks Ok begin order gui
                        [sg.Ok("Order"), sg.Cancel()]
                     ]
                 
                 window2 = sg.Window('Order', orderlayout, size=(500,500))
                 pricetotal = 0
                 while True:
                     orderitems = ""
                     if str(window.Element('nameofp').Get()) == "": #Checks for a name, if not program does not continue
                         sg.Popup("Error - No Name Supplied!")
                         window2.close()
                         break
                     print(window.Element('cashrcard').Get())
                     if window.Element('cashrcard').Get() == "Cash" or window.Element('cashrcard').Get() == "Card": #Asks what the preferred payment type is
                         pass
                     else:
                         sg.Popup("Error - No Payment Specified")
                         window2.close()
                         break
                     orderitems += "Name: " + str(window.Element('nameofp').Get()) + "\n===\n"
                     event, values = window2.read(timeout=1)
                     counter=0
                     for orderamount in itemlistspinner: #For this variable, order amount, go through each item in listspinner and check the value of it. If over 0, add to receipt and add relevant amount with it
                         print(orderamount)
                         if int(window.Element(orderamount).Get()) > 0:
                             orderitems += itemlist[counter] #Needed so we know where we are in the loop to add the correct item from the list
                             orderitems += "\n"
                             orderitems += "x"
                             orderitems += window.Element(orderamount).Get()
                             sanitycheck += int(window.Element(orderamount).Get()) #If nothing is ordered we need to reset the receipt
                             orderitems += "\n"
                             orderitems += "£" + str(format(float(pricelist[counter]) * float(window.Element(orderamount).Get()),'.2f')) #Add the relevant price to an item, using counter to grab from pricelist
                             orderitems += "\n---\n"
                             pricetotal += pricelist[counter] * int(window.Element(orderamount).Get())
                         counter+=1 #Add to counter each loop
                     orderitems += "Sauce: \n"
                     orderitems += window.Element('sauceitem').Get()
                     orderitems += "\n==="
                     orderitems += "\n"
                     pricetotal += 0.4 #0.4 added to the total
                     if window.Element('sauceitem').Get() == None or window.Element('sauceitem').Get() == "":
                         pricetotal = 0
                         sg.Popup("Error - Please Select a Sauce Option") #Error if nothing is selected
                         window2.close()
                         break
                     elif window.Element('sauceitem').Get() == "No Sauce":
                         pricetotal -= 0.40 #Subtract previous addition if the sauce is No Sauce
                     else:
                         pass

                     if window.Element('inrout').Get() == None or window.Element('inrout').Get() == "":
                          pricetotal = 0
                          sg.Popup("Error - Please Select a if you want to eat in or take out") #Error if nothing is selected
                          window2.close()
                          break
                     elif window.Element('inrout').Get() == "Take-Away {Free}":
                          pass
                     else:
                          pricetotal += 0.10
                          orderitems += "\n---\n You are eating in at 10 pence\n---\n"

                    
                     orderitems += "\n===\nTOTAL PRICE: " + str(format(pricetotal,'.2f')) + " Pounds.\n" #Finally add total price to receipt
                     if sanitycheck == 0:
                         orderitems = ""

        
                     sanitycheck = 0 #Reset the sanity check
                     
                     window2.FindElement('orderfinal').Update(value=orderitems) #Update GUI with receipt
                     print(orderitems) #Shows you your order
                     event, values = window2.read()
                     if event in (None, 'Cancel'):
                         pricetotal = 0
                         window2.close() #If user presses cancel, reset price or it will stack on 
                         break
                     if event in (None, 'Order'):
                         if orderitems == "":
                             sg.Popup("Error - Nothing ordered!")
                             window2.close() #If order items are blank, prevent ordering
                             break
                         sanitycheck = 0 #Resets again
                         for orderamount in itemlistspinner:
                             window.FindElement(orderamount).Update(value=0)
                             window.FindElement('sauceitem').Update(value="") #Clearing out if order is successful
                         sg.Popup("Thanks for ordering come again")
                         window.FindElement('nameofp').Update(value="")
                         window.FindElement('cashrcard').Update(value="")
                         pricetotal = 0 #Reset price and person name
                         window2.close()
                         break

    
window.close()

