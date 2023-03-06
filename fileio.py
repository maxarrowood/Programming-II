lines = ["Hello, ", "World", "!"]

# file write mode 'w' is "overwrite" by default
# use a for append
with open("data/myfile.txt", 'w') as f:
  # write data to a file
  f.write("Hi \n")
  f.writelines(lines)
  # or, for line in lines: file.write(line)

with open("data/myfile.txt", 'r') as f:
  # reading from a file
  print(f.read())