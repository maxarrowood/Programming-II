import random
import numpy as np

def printMatrix(mat):
  for row in mat:
    for num in row:
      print(f"{num:3d} ", end="")
    print()

def transposeMatrix(mat):
  newMat = np.transpose(mat)
  print("\nTransposed Matrix")
  printMatrix(newMat)

def main():
  mat1 = []
  for r in range(5):
    row1 = []
    for c in range(5):
      rnd1 = random.randint(-50, 99)
      row1.append(rnd1)
    mat1.append(row1)

  print("Matrix")
  printMatrix(mat1)

  transposeMatrix(mat1)


if __name__ == "__main__":
  main()