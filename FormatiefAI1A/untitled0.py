# -*- coding: utf-8 -*-
"""
Created on Mon Feb  1 14:11:33 2021

@author: Gebruiker
"""

def pyramide():
    print("pyramide")
    grootte = int(input("Geef een integer op."))
    methode = int(input("1 voor while loop methode, 2 voor for loop methode."))
    # kant = int(input("1 voor naar links, 2 voor naar rechts."))
    text = ""
    
    if methode == 1: 
        print("Methode 1")
        i = 1
        while i < grootte:
            text += "*"*i + "\n"
            i += 1
        while i > 0:
            text += "*"*i + "\n"
            i -= 1
    elif methode == 2:
        print("Methode 2")
        for i in range(1, grootte+1):
            text += "*"*i + "\n"
        for i in range(grootte-1, 0, -1):
            text += "*"*i + "\n"
    
    print(text)
    
def tekstCheck():
    print("tekstCheck")
    text1 = input("Geef eerste text: ")
    text2 = input("Geef tweede text: ")
    index = 0
    
    
    for letterA in text1:
        if letterA != text2[index]:
            print(f"Verschil gevonden op index {index}")
            break
        else:
            index += 1
    
def lijstCheck():
    print("lijstCheck")
    
    def count():
        
    
def palinDroom():
    print("palinDroom")
    
def sorteren():
    print("sorteren")
    
def gemiddeldeBerekenen():
    print("gemiddeldeBerekenen")

def random():
    print("random")

def compressie():
    print("compressie")
    
def cyclischSchuiven():
    print("cyclischSchuiven")

def fibonaci():
    print("fibonaci")
        
def caesarCijfer():
    print("caesarCijfer")
    
def fizzBuzz():
    print("fizzBuzz")
    
def run():
    # opgave = int(input("Geef een getal op, tussen 1-12 voor de bijbehorende opdracht"))
    # opgaven = (pyramide, tekstCheck, lijstCheck, palinDroom, sorteren, gemiddeldeBerekenen, random, compressie, cyclischSchuiven, fibonaci, caesarCijfer, fizzBuzz)    
    # opgaven[opgave-1] + ()
    # pyramide()
    tekstCheck()
    
    
run()
