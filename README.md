# PicoPlacaPredictor
This little program allows the user to know if their vehicle has "Pico y Placa" during a certain date and time.

For this to work the user must input the following:
- Their plate number, it has to be complete and in the correct format (ej. ICC793).
- Any date with the following format: yyyy-mm-dd.
- A time in a 24hr format (hh:mm).

When everything is ready, the program shows to the user if the can use their vehicle or not.

This programs uses the following rules for Pico y Placa:

- Each day, excluding saturday and sunday, some veicles can be on the road and some others can't based on their last digit of their plate. This table shows each day and plate:

    | Day of the week  |      Last digits     |
    |----------|:-------------:|
    | Monday |  1 and 2 |
    | Tuesday |  3 and 4   |
    | Wednesday | 5 and 6 |
    | Thursday | 7 and 8 |
    | Friday | 9 and 0 |

- Pico y Placa is valid during 7:00 to 9:30 and from 16:00 to 19:30.