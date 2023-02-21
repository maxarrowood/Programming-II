class LP311:
  def __init__(self, des, cod, deb, tes):
    self.design = des
    self.coding = cod
    self.debugging = deb
    self.testing = tes
    self.time = 0
    self.percents = [0]*4

  def _percent(self, number):
    return round((number / self.time) * 100, 2)

  def calculate(self):
    self.time = self.design + self.coding + self.debugging + self. testing
    self.percents[0] = self._percent(self.design)
    self.percents[1] = self._percent(self.coding)
    self.percents[2] = self._percent(self.debugging)
    self.percents[3] = self._percent(self.testing)

  def display(self):
    print("Category\t\tTime")
    print(f"Designing\t\t{self.percents[0]}%")
    print(f"Coding\t\t\t{self.percents[1]}%")
    print(f"Debugging\t\t{self.percents[2]}%")
    print(f"Testing\t\t\t{self.percents[3]}%")

def main():
  print("Enter amount of time spent last month on the following activites: \n")
  designing = float(input("Desinging: "))
  coding = float(input("Coding: "))
  debugging = float(input("Debugging: "))
  testing = float(input("Testing: "))
  print()

  time = LP311(designing, coding, debugging, testing)
  time.calculate()
  time.display()

if __name__ == "__main__":
  main()