class Circle:
  def __init__(self, rad):
    self.rad = rad
    self.circum = 0
    self.area = 0
    self.pi = 3.14159

  def calc(self):
    self.area = self.pi * self.rad ** 2
    self.circum = 2 * self.pi * self.rad

  def getArea(self):
    return self.area

  def getCircum(self):
    return self.circum