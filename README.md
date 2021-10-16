# CodeTestverivox

## Use
Available tariffs `/Tariffs`
<br>
Ex.
 ``` 
     [
   {
      "name":"Basic electricity tariff",
      "description":"base costs per month 5 € + consumption costs 22 cent/kWh",
      "annualCosts":0
   },
   {
      "name":"Packaged tariff",
      "description":"800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30",
      "annualCosts":0
   }
]
 ``` 
<br></br>
Search tariff by Name `/Tariffs/Tariff/{value}`
<br>
 Ex.: /Tariffs/Tariff/Basic
  ``` 
  [
   {
      "name":"Basic electricity tariff",
      "description":"base costs per month 5 € + consumption costs 22 cent/kWh",
      "annualCosts":0
   }
]
``` 
<br></br>
Calculate Tariffs  `/Tariffs/calc/{Consumption}/{value}`
<br>
("ConsumptionkWhYear" is the only option for the moment.The idea is to eventually accept the parameter in others types of value ex. Watts)
Ex.: /Tariffs/calc/ConsumptionkWhYear/3500   
<br>
``` 
[
   {
      "name":"Basic electricity tariff",
      "annualCosts":770
   },
   {
      "name":"Packaged tariff",
      "annualCosts":800
   }
]
```
<br></br>


## Updating the API
### Creating new tariffs
1. Create a new Item in the tariffs list located in TariffsController.cs:14
![image](https://user-images.githubusercontent.com/12504922/137389965-aa61c96e-2d90-4fe0-b692-c75395c95b69.png)
2. Create a new condition using the tariff's name and configurating a new formula in CalculateAnnualCosts located in Tariff.cs:15
![image](https://user-images.githubusercontent.com/12504922/137390180-97e0159b-cf42-4a24-87f0-fb6214b1b464.png)
