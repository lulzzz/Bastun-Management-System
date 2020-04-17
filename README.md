BMS is a detached departure control system for providing ground-handling services in the aviation industry. 

The aim of this project is to simplify the use of ground-handling software in the aviation industry since I found that the majority of such software has an old and difficult to use interface with most of the necessary functionality for dispatching an aircraft not being segregated into neat and easy to use modules, along with generally failing to take the human factor into account and multiple flights being delayed as a result of bad software. The aim of this project has been to solve this problem in a manner that takes the handling agent into account and makes their job much easier.

BMS supports the following functionalities:
 -Creation of inbound and outbound flights
 -Creation and sending of arrival and departure movements to the prerequisite operating department
 -Creating and sending messages for both inbound and outbound flights
 -Adding a fuel form for a particular flight
 -Adding a weight form for a particular aircraft that will be operating a particular flight
 -The check-in of passengers for a particular flight and registering their suitcases
 -Creating a Loading Instruction which shows how an aircraft is supposed to be loaded
 -Creating a Loadsheet which shows the distribution of paying loads in the aircraft
 -Creation of a passenger manifest for the outbound leg of a flight
 -A system of departure control system with built in support for delay codes and reasons behind the potential delay of a flight
 
 Explanation for the way in which some of the project functionalities are supposed to be used:
 
 
 -Movements:
 A movement is the landing and takeoff of an aircraft at an airport.
 Arrival movements dictate when a flight has landed at an airport and shows the touchdown and on-block times.
 Arrival movements are supposed to be entered in this format only:
MVT
(Inbound flight number)/(Day of flight).(Aircraft registration).(Handling station)
AA(TouchdownTime)/(Onblock)
SI(Additional information here) - if there is no supplementary information, simply enter NIL

Departure movements are supposed to be entered in this format only:
MVT
(Outbound flight number)/(Day of flight).(Aircraft registration).(Handling station)
AD(Offblock time)/(Takeoff time) ETA 2345 (Arrival station)
PAX(Total outbound passengers)
SI(Additional information here) - if there is no additional information, simply enter NIL
 
 
