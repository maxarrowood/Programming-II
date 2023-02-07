pi = 3.14159


def calcArea(rad):
  return pi * rad**2


def calcCircum(rad):
  return 2 * pi * rad


def areaCircum(rad):
  area = calcArea(rad)
  circum = calcCircum(rad)
  return area, circum


def main():
  radius = int(input("Radius: "))
  a, c = areaCircum(radius)
  print("Area: " + str(a) + " Circumference: " + str(c))

if __name__ == "__main__":
  main()