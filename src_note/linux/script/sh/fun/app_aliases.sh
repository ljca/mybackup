#!/bin/bash -
# Some applications aliases and functions……

# File Browser 1
function fb1()
{
  pcmanfm $1 &>/dev/null&
}

# File Browser 2
function fb2()
{
  thunar $1 &>/dev/null&
}

# Pdf Browser
type pdfb &>/dev/null || alias pdfb='masterpdfeditor3 &>/dev/null&'

# Web Browser
type webb &>/dev/null || alias webb='firefox &>/dev/null&'

# Music Player:mocp
type mpr &>/dev/null || alias mpr='mocp -r'
type mpf &>/dev/null || alias mpf='mocp -f'

# Music Player :RhythmCat
type msp &>/dev/null || alias msp='RhythmCat &>/dev/null &'


# Picture Browser
type picb &>/dev/null || alias picb='ristretto &>/dev/null&'

