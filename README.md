# פרוייקט כספומט דיגיטלי : 



## הפרוייקט הינו הדמיה של בנק וירטואלי כאשר יש לך שם משתמש וסיסמא כדי להיכנס לחשבון שלך
## ולנהל שם פעולות משתמש כגון משיכה , הפקדה העברה וכו' מפורט בהמשך בפונקציונאלייות הפרוייקט
<br/>
<br/>
<br/>

### בפרוייקט יש אפשרות להרשמה עם ולידציה של אימייל
### הפרוייקט מציג יכולות של ממשק משתמש מודרני ,
### תכנות בשימוש עקרונות תכנות מונחה עצמים , 
### ניהול של מסד נתונים SQLServer,
### שילוב של כמה שפות קוד בתוכנה אחת (CommandPrompt,SQL,C#,Python,HTML&CSS)

<br/>
הכל מפורט בהמשך .
<br/>
<br/>

### לפני שאני מפרט על הפרוייקט הייתי רוצה לצרף תמונה של הדיאגרמה שלי ב  sql כדי שתוכלו לראות את הקשרים שעשיתי ותמונה יותר גדולה של המערכת מאחורי הפרוייקט :
<br/>
<br/>
<br/>
<br/>
<br/>

![alt text](https://github.com/orshani1/EntityFrameWork_Project/blob/Main/%E2%80%8F%E2%80%8F%D7%9C%D7%9B%D7%99%D7%93%D7%94.PNG?raw=true)

<br/>
<br/>
<br/>
<br/>
<br/>

### בפרוייקט הצלחתי לממש 3 design patterns  אבל אני רוצה להזכיר בשורה הזאת את הgeneric repository(תודה למארק המתרגל) 
### עם מימוש של unitofwork  אני  לא אצרף פה תמונה כי אי אפשר לראות את המימוש בתמונה אחת בשביל לראות את המימוש אפשר להיכנס לפרוייקט ה DB ושם נמצא המימוש :sunglasses:
<br/>
<br/>
<br/>

### הפרוייקט תומך כולו ביסודות OOP
### קוד שמספר סיפור
<br/>
<br/>

### בפרוייקט הצלחתי גם לשלב עבודה עם פייתון ו  cmd
 מצרף תמונה למטה :
<br/>
<br/>
<br/>
<br/>

![alt text](https://github.com/orshani1/EntityFrameWork_Project/blob/Main/workingwithcmd.PNG?raw=true)


<br/>
<br/>
<br/>
<br/>

### בפרוייקט הצלחתי גם לשלב  עבודה עם שליחת אימייל
### לשם ולידציה של המשתמש . 
<br/>
<br/>
<br/>
מצרף תמונה למטה :
<br/>
<br/>
<br/>
<br/>

![alt text](https://github.com/orshani1/EntityFrameWork_Project/blob/master/smtp.PNG?raw=true)

<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
<br/>
# בפרוייקט שילבתי הרבה למידה עצמית והראתי הרבה יכולות שלא לימדו אותנו בקורס. 
### כמו שהראתי בתמונות למעלה כגון : 
<br/>
<br/>
<ul>
	<li>
		 עבודה עם מחלקת Procces
	<li/>
	<li>
			רשימת קוד לשורת הפקודה וביצוע שלו
	<li/>
	<li>
		עבודה עם מחלקת SmtpClient	
	<li/>
	<li>
		עבודה עם מחלקת MailMessage
	<li/>
	
<ul/>
<br/>
# בחלון ה login  יש אופציה ללחוץ על label our website בשביל להיכנס לאתר של התוכנה .
<br/>
<br/>     
### הוספתי אתר של עמוד אחד בלי יותר מדי פונקצונאליות רק בשביל להראות יכולות CSS עשיתי את זה לקראת סוף הפרוייקט כי לא מצאתי איזה עוד פונקציונאליות אני יוכל להוסיף ###לפרוייקט עצמו
<br/>
<br/>
<br/>
	
# פונקציונאליות של הפרוייקט :
| Admin  | Normal User |
| ------------- | ------------- |
| Has the same Actions As User | Can see his Actions from the very start of the registery  |
| Can Delete An Account from the system| Can Withdraw/Deposit from his balance |
| Delete Accounts Credit cards | Can Request/Pay His Loan and see his Loans List|
| Can Change all of the Accounts Details ,For Example:Account Number,UserName,Password,Balance | Can Transfer From his account to another account in our system|
| Can See The List of all the clients in our system  | Can Create new Saving ,Deposit to this Saving ,Withdraw From him part of the amount or all of it and see his Savings list|
| Can Write An Email Message to one or all of the Users in our system  | Can Edit his Personal Details for example : Password ,Email adress ,Phone number|

### משתמש רגיל : 


	יכול לראות את העובר ושב שלו עם כל הפעולות שבוצעו מאז יצירת המשתמש					
	יכול למשוך כסף /להפקיד כסף.
	יכול לקחת הלוואה לשלם הלוואה ולראות את רשימת ההלואות הקיימות .
	יכול להעביר כסף לחשבון אחר שקיים במערכת.
	יכול ליצור חסכון חדש ,להפקיד אליו כסף , ולמשוך ממנו חלק מהסכום או את כולו ולראות את רשימת החסכונות הקיימים.
	יכול לבקש להוסיף כרטיס אשראי חדש , לבטל קיים  ולראות את רשימת הכרטיסים .
	יכול לערוך את הנתונים האישיים שלו כגון סיסמא כתובת אימייל ופלאפון.


### אדמין : 

	בעיקרון הקו מחשבה שלי לפעולות של אדמין בפרוייקט הנל זה פשוט גישה יותר נוחה למסד נתונים  מהממשק משתמש
	אדמין יכול למחוק משתמש,
	למחוק כרטיסים למשתמשים
	לשנות את כל ההגדרות של החשבונות 
	כגון: בלאנס ,מספר חשבון , שם משתמש וסיסמא 
	אדמין יכול לראות רשימה של  כל הלקוחות הקיימים במערכת 
	אדמין יכול לרשום אימייל ללקוח מסויים או לכולם מהמערכת
	וכמובן שגם אדמין יכול לעשות את כל הפעולות של משתמש רגיל כי גם הוא משתמש של הבנק פשוט עם יוכולות יותר גבוהות 



<br/>
<br/>
<br/>
<br/>
### בחלק הבא אני הולך לציין על הDesign Patterns
<br/>
<br/>
<br/>
### ויהיה לי יותר קל לפרט עליהם באנגלית אבל שנייה לפני אני צריך לרשום כמה דברים שלא הצלחתי לתקן והם לא יעבדו לכם אם תנסו 
## אז ככה 
<br/>
<br/>
<br/>

### בפרוייקט כן הצלחתי ליישם עבודה עם שליחת אס-אמ-אס למספר פלאפון . 
<br/>
<br/>
### אבל יש בעיה בשביל שאני יוכל לשלוח הודעה למספר פלאפון שהוא לא המספר שלי 
### אני צריך לשלם כסף לTwilio הנוכלים.
<br/>
<br/>
### אז בגלל שאני תפרן , המשתמש לא יכול להירשם ולעשות ולידציה בעזרת מסרון לפלאפון . 
<br/>
### אז בבקשה אל תנסו את זה זה לא יעבוד וישלח לי סתם הודעות לפאלפון 
### במקום זה תרגישו חופשי לעשות ולידציה בעזרת אימייל כי זה עובד 
:smiley:



<br/>
<br/>
<br/>
<br/>



# Design Patterns:

## In the project i was able to implement 3 Design Patterns : 

### Number 1 : 
        Single Tone ... in the MethodList class there is an singletone implementation 
### Number 2 : 
        Factory Method ... in the Models file There is alot of factory methods that create instances of the present models 
### Number 3 : (save the best for last)
        GenericRepository the one that i most proud of . 
        in the DB Data accsess layer there is an implement of generic repository and unitofwork 
        i implemented all of that on my models as you can see in the db DAL 


# Final Notes (Please read this its important) : 

        i couldn't change the modelss file name to models with 1 S . it wont change 

# the admin username and password is : 
        username : orshani8
        password : orshani1

### Feel free to register but just dont choose the phone validation option
### becuase i use twilio api i cant send sms to other phone numbers than my phone 


Hope you find this project Professional enough

ty for reading and have fun .
<br/>
<br/>
<br/>
 
////////
	
	
	
	
	
	
# Credits:
# רוצה להודות למארק המתרגל שעזר לי עם repository patterns
# בלעדיו לא הייתי מיישם את התבנית עיצוב הזאת
# ומגלה איך לערוך את הקובץ Read me  הזה 
## תודה ל stackoverflow 
## תודה ל youtube
## ותודה למורה שהולך לקורא את זה מקווה שתיתן לי ציון הצגה :wink:
	







