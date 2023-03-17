class Animal:
  def __init__(self, name):
    self._name = name

  def getName(self):
    return self._name

class Hiccas(Animal):
  def __init__(self, name, fur):
    super().__init__(name)
    self.fur = fur

class Wallies(Animal):
  def __init__(self, name, steps):
    super().__init__(name)
    self.steps = steps

class Beepers(Animal):
  def __init__(self, name, word):
    super().__init__(name)
    self.word = word