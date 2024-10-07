a = int(input('enter number'))
b = int(input('another number'))
c=(a+b)**3
print(c)
rev = 0
while c>0:
    remainder = c %10
    rev = (rev *10) + remainder
    c = c //10
print("\n reverse number is  = %d" %rev)
