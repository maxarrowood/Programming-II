
temp = 0
num1 = int(input("Enter a # : "))
num2 = int(input("Enter a Second # : "))

if num1 < 0 or num2 < 0:
  print("Enter a positive number.")

while num2 > 0:
  temp = num1 % num2
  num1 = num2
  num2 = temp

print("The GCD is : ", num1)