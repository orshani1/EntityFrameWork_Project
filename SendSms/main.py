
# we import the Twilio client from the dependency we just installed
from twilio.rest import Client

# the following line needs your Twilio Account SID and Auth Token
client = Client("ACd782f38f641befa314cadc332ba0a8fa", "c0c340ea6c4bb9d7e437b5d098be91f8")

# change the "from_" number to your Twilio number and the "to" number
# to the phone number you signed up for Twilio with, or upgrade your
# account to send SMS to any phone number
client.messages.create(to="+972506951678",
                       from_="+14708239648",
                       body="Hello New User Your Verification Code is:\n"
                            "5964")



