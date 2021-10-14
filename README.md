# CodeTestverivox

<b>Use</b>
Available tariffs - /Tariffs<br>
Ex.<br>
      [<br>
   {<br>
      "name":"Basic electricity tariff",<br>
      "description":"base costs per month 5 € + consumption costs 22 cent/kWh",<br>
      "annualCosts":0<br>
   },<br>
   {<br>
      "name":"Packaged tariff",<br>
      "description":"800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30",<br>
      "annualCosts":0<br>
   }<br>
]<br>
    
Search tariff by Name - /Tariffs/Tariff/{value}
 Ex.: /Tariffs/Tariff/Basic
Ret  
    [
   {
      "name":"Basic electricity tariff",
      "description":"base costs per month 5 € + consumption costs 22 cent/kWh",
      "annualCosts":0
   }
]

Calculate Tariffs  -  /Tariffs/calc/{Consumption}/{value}
Ex.: /Tariffs/calc/ConsumptionkWhYear/3500
Ret 
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
ps.: "ConsumptionkWhYear" is the only option for the moment


<b>Tariffs</b>
