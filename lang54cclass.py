from Cl54c import *

def main():
  rad = int(input("Enter Radius: "))
  circle = Circle(rad)  # Call "Shape" Constructor
  circle.calc()
  print("Area:", circle.getArea())
  print("Perimeter:", circle.getCircum())


if __name__ == "__main__":
  main()
