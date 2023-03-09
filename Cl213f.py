class Cl213f:

  def __init__(self, kwh):
    self.kwh = kwh
    self.cost = 0

  def calc(self):
    if self.kwh <= 2000:
      self.cost = 0.07 * self.kwh
    elif self.kwh >= 2001 and self.kwh <= 10000:
      self.cost = ((self.kwh - 2000) * 0.05) + 2000 * 0.07
    elif self.kwh > 10001:
      self.cost = ((self.kwh - 10000) * 0.04) + (2000 * 0.07) + (8000 * 0.05)
    self.cost = round(self.cost, 2)

  def __str__(self):
    return f"The cost of {self.kwh} kwh is ${self.cost}"
