def f(n):
    output=[]
    for i in range(1,n+1):
        if i%3==0 and i%4==0:
            output.append("FizzBuzz")
        elif i%3==0:
            output.append('Fizz')
        elif i%4==0:
            output.append("Buzz")
        else:
            output.append(i)
    return output

x=int(input("Please enter a number: "))
y=f(x)
print("Here is your FizzBuzz: ", y)
