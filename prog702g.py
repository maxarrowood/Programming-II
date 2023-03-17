from Cl702g import *

def main():
  try:
    animals = []
    with open("data/prog702g.txt" , 'r') as f:
      num = int(f.readline())
      while num != 99:
        name = f.readline()
        if num == 1:
          fur = int(f.readline())
          a = Hiccas(name, fur)
          animals.append(a)
          # done through here
        elif num == 2:
          numStu = int(f.readline())
          p = Teacher(fn, ln, numStu)
          people.append(p)
        elif num == 3:
          favW = f.readline().strip()
          p = Admin(fn, ln, favW)
          people.append(p)
        num = int(f.readline())
  except Exception as e:
    print("Error:", e)


if __name__ == "__main__":
  main()