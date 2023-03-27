import sys
sys.setrecursionlimit(10000)

def down(n):
  if n == 3:
    return n
  return n + down(n-3)

def main():
  num = int(input("Enter a number: "))
  while num != 0:
    downn = down(num)
    print(f"{num}! = {downn}")
    num = int(input("Enter a number: "))

if __name__ == "__main__":
  main()