<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# Markdown Reference
## Format Text

*Italic emphasis* , _Alternative italic emphasis_

**Bold emphasis** , __Alternative bold emphasis__

~~Strikethrough~~

Break line (two spaces at end of line)  

> Block quote

`Inline code`

```
Code blocks
are
awesome
```

<!-- --------------- -->

## Tables

| Left aligned | Middle aligned | Right aligned |
| :--------------- | :------------------: | -----------------: |
| Test                 | Test                      | Test                    |
| Test                 | Test                      | Test                    |

<!-- Comment: Not visibile in view. Can also span across multiple lines. End with:-->

<!-- ------------- -->

<!-- 

## Math (KaTeX)
See [reference](https://katex.org/docs/supported.html) & [examples](https://github.com/waylonflinn/markdown-it-katex/blob/master/README.md). Enable by checking Math at `Settings > Markdown`.

### Math inline

$ I = \frac V R $

### Math block

$$\begin{array}{c} 
abla \times \vec{\mathbf{B}} -\, \frac1c\, \frac{\partial\vec{\mathbf{E}}}{\partial t} & = \frac{4\pi}{c}\vec{\mathbf{j}} 
abla \cdot \vec{\mathbf{E}} & = 4 \pi \rho \\ 
abla \times \vec{\mathbf{E}}\, +\, \frac1c\, \frac{\partial\vec{\mathbf{B}}}{\partial t} & = \vec{\mathbf{0}} \\ 
abla \cdot \vec{\mathbf{B}} & = 0 \end{array}$$

$$\frac{k_t}{k_e} = \sqrt{2}$$

------------- -->

## Format Text (continued)

### Text color

<span style='background-color:#ffcb2e;'>Text with background color / highlight</span>

<span style='color:#3333ff;'>Text foreground color</span>

<span style='text-shadow: 0px 0px 2px #FF0000;'>Text with colored outline</span> / <span style='text-shadow: 0px 0px 2px #0000FF; color: white'>Text with colored outline</span>

### Text sub & superscript

<u>Underline</u>

The <sub>Subway</sub> sandwich was <sup>super</sup>

Super special characters: ⁰ ¹ ² ³ ⁴ ⁵ ⁶ ⁷ ⁸ ⁹ ⁺ ⁻ ⁼ ⁽ ⁾ ⁿ ™ ® ℠

### Text positioning
<div markdown='1' align='right'>

text on the **right**

</div>

<div markdown='1' align='center'>

text in the **center**  
(one empy line above and below  
required for Markdown support OR markdown='1')

</div>

### Block Text

<div markdown='1' style='text-align: justify; text-justify: inter-word;'>
lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. 
</div>

### Dropdown

<details markdown='1'><summary>Click to Expand/Collapse</summary>

Expanded content. Shows up and keeps visible when clicking expand. Hide again by clicking the dropdown button again.

</details>

### Break page
To break the page (/start a new page), put the div below into a own line.
Relevant for creating printable pages from the document (Print / PDF).

<div style='page-break-after: always'></div>

<!-- ------------- 

## Charts / Graphs / Diagrams (mermaidjs)
Pie, flow, sequence, class, state, ER  
See also: mermaidjs [live editor](https://mermaid-js.github.io/mermaid-live-editor/).

```mermaid
graph LR
    A[Square Rect] -- Link text --\> B((Circle))
    A --\> C(Round Rect)
    B --\> D{Rhombus}
    C --\> D
```

-->

## Admonition Extension
Create block-styled side content.  

!!! warning 'Optional Title'
Use one of these qualifiers to select the icon and the block color: abstract, summary, tldr, bug, danger, error, example, snippet, failure, fail, missing, question, help, faq, info, todo, note, seealso, quote, cite, success, check, done, tip, hint, important, warning, caution, attention.
    Block-Styled Side Content with **Markdown support**

!!! info ''
    No-Heading Content

??? bug 'Collapsed by default'
    Collapsible Block-Styled Side Content

???+ example 'Open by default'
     Collapsible Block-Styled Side Content

------------------

This Markdown reference file was created for the [Markor](https://gsantner.net/project/markor?source=markdownref) project by [Gregor Santner](https://gsantner.net) and is licensed [Creative Commons Zero 1.0](https://creativecommons.org/publicdomain/zero/1.0/legalcode) (public domain). File revision 3.

------------------

