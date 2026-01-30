import random
a=[1,2,3,4,5,6,7,8,9,10]
n=len(a)

for i in range(n-1,0,-1):
    print("i =",i)
    j=random.randint(0, i)
    print("j =", j)
