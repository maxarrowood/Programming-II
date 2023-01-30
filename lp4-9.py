import random

p = int(input("Enter a number 1 - 20: "))

comp = random.randint(1,20)

print("Your Number: " + str(p))
print("The Computer's Number: " + str(comp))

if p > 20:
    print("Your Number is too high!")
elif p == comp:
  print("You win!")
else:
  print("You Lose")