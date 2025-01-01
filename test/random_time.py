import serial
import time
import random
from datetime import datetime, timedelta

def generate_random_date():
    start_date = datetime(2025, 1, 1)
    end_date = datetime(2025, 1, 30)
    random_date = start_date + (end_date - start_date) * random.random()
    return random_date.strftime("%d/%m/%Y")

def generate_random_time():
    start_time = datetime.strptime('07:00:00', '%H:%M:%S')
    end_time = datetime.strptime('21:00:00', '%H:%M:%S')
    delta = end_time - start_time
    random_seconds = random.randint(0, int(delta.total_seconds()))
    random_time = (start_time + timedelta(seconds=random_seconds)).time()
    return random_time.strftime("%H:%M:%S")

def determine_type_of_time(random_time_str):
    random_time = datetime.strptime(random_time_str, '%H:%M:%S').time()
    
    if random_time < datetime.strptime('08:00:00', '%H:%M:%S').time():
        return "IN_OK"
    elif datetime.strptime('08:00:30', '%H:%M:%S').time() < random_time < datetime.strptime('12:00:00', '%H:%M:%S').time():
        return "IN_LATE"
    elif datetime.strptime('13:00:00', '%H:%M:%S').time() < random_time < datetime.strptime('17:00:00', '%H:%M:%S').time():
        return "OUT_SOON"
    else:
        return "OUT_OK"

def generate_message():
    id = random.randint(1, 5)
    date = generate_random_date()
    time = generate_random_time()
    type_of_time = determine_type_of_time(time)
    
    message = f"*#{id}_{date}_{time}_{type_of_time}#"
    return message

def send_serial_data():
    ser = serial.Serial('COM2', 9600)
    try:
        while True:
            message = generate_message()
            ser.write(message.encode('utf-8'))
            print(f"Sent: {message}")
            time.sleep(2)
    except KeyboardInterrupt:
        ser.close()

if __name__ == "__main__":
    send_serial_data()
