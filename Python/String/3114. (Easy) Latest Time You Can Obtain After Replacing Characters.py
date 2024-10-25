class Solution:
    def findLatestTime(self, s: str) -> str:
        hours, minutes = s.split(':')

        if hours == "??":
            hours = "11"  
        else:
            if hours[0] == "?":  
                if hours[1] in "01":
                    hours = "1" + hours[1]
                else:
                    hours = "0" + hours[1]
            elif hours[1] == "?":  
                if hours[0] == "1":
                    hours = hours[0] + "1"  
                else:
                    hours = hours[0] + "9"  

        if minutes == "??":
            minutes = "59"
        else:
            if minutes[0] == "?":
                minutes = "5" + minutes[1]  
            elif minutes[1] == "?":
                minutes = minutes[0] + "9"  

        return hours + ":" + minutes