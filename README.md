# Basic Algorithms

A repository to use as a cheatsheet for some basic algorithms written in C#.\
I tried to write them as clear as I could in order to be understandable to everyone regardless of level.\
For each algorithm you are going to find a section with a summary explanation.

## Description

<details>
    <summary>Binary Search</summary>
    <ul>
        <li>Console Application that uses Binary Search iterative</li>
        <li>This algorithm it is applicable only on sorted arrays</li>
        <li>It is an efficient way to find an element into an array. Its time complexity is O(log(n)) compared to linear search which is O(n)</li>
        <li>Linear search is the one that parses the array element by element and compares with item to search.</li>
        <li>The algorithms continuously split the array in halves and compare the element to find with the middle of the split array</li>
        <li>It is a common use case to return the position of the element in the array otherwise returns null</li>
    </ul>
</details>
<details>
    <summary>Graphs</summary>
    <ul>
        <li>Console Application that shows Breadth First Search on a graph</li>
        <li>Graph algorithms are of the most useful ones</li>
        <li>A graph is a way of modeling a set of relationships</li>
        <li>It leverages the behaviour of a Queue data structure </li>
        <li>It is used to find the shortest path between 2 nodes</li>
        <li>Compared to trees the algorithm is slightly different because we need to keep track of visited nodes</li>
        <li>The algorithm must visit each node once</li>
    </ul>
</details>
<details>
    <summary>Greedy</summary>
    <ul>
        <li>Console Application that shows the greedy way to solve a problem</li>
        <li>Greedy is not an algorithm. It is a strategy in solving some particular problems</li>
        <li>Calculating the best solution may be too expensive and here comes the greedy strategy with an approximation </li>
        <li>Key identifiers for problems where greedy is a solution:</li>
        <li>When it’s needed to calculate all possible combinations</li>
        <li>When algorithms runs quickly for a small amount of items but slow with more items</li>
        <li>A problem where it’s not possible to break it into sub-problems</li>
        <li>If the algorithm has O(n!) time complexity it may be a sign that the developer can try the greedy strategy (not mandatory)</li>
    </ul>
</details>
<details>
    <summary>Quicksort</summary>
    <ul>
        <li>Console Application that shows Quicksort algorithm</li>
        <li>It is a sorting problem with improved efficiency compared to Selection Sort</li>
        <li>It is required to have recursion knowledge</li>
        <li>First step choses a pivot - an element from array. Then we have a sub-array with numbers less than pivot and a sub array with numbers higher than the pivot. In our case we always pick the first element of the array</li>
        <li>Second step is to call quicksort recursively on each sub-array</li>
        <li>The algorithm takes O(n*log(n)) time</li>
    </ul>
</details>
<details>
    <summary>Recursion</summary>
    <ul>
        <li>Console Application that uses Binary Search recursively</li>
        <li>Recursion does not bring any improvements in terms of efficiency, but it is a clearer solution</li>
        <li>A lot of popular algorithms use recursions therefore it is very useful to comprehend this concept</li>
        <li>A recursive function has 2 parts: base case and recursive case</li>
        <li>Base case is when function stops calling itself and starts going back providing values avoiding infinite loop</li>
        <li>Recursive case as the implies is when the function calls itself</li>
        <li>Each function call is pushed into the call stack until it reaches the base case afterwards it starts to pop the function calls</li>
    </ul>
</details>
<details>
    <summary>Selection Sort</summary>
    <ul>
        <li>Console Application that shows Selection Sort algorithm</li>
        <li>It is a sorting algorithm with pretty bad performance </li>
        <li>It parses the array element by element and you have to check each element if it is the smallest. This operation takes O(n) time and perform that <em>n</em> times</li>
        <li>That takes O(n^2) time</li>
        <li>Check out quicksort for better performance</li>
    </ul>
</details>
<details>
    <summary>Trees</summary>
    <ul>
        <li>Console Application that shows 2 methods to parse a tree</li>
        <li>An algorithm that parses a tree using Breadth First Search and displays the nodes numbers</li>
        <li>An algorithm that parses a tree using Depth First Search and displays the node numbers</li>
        <li>Breadth first search is usually used to find the shortest path between 2 nodes</li>
        <li>Depth first search is usually used for topological sorting and finding cycles in a graph</li>
        <li>A tree is a connected acyclic graph</li>
    </ul>
    <strong>Which one to choose?</strong>
    <p>Search for hints. If there is a requirement to find the shortest distance then definitely use BFS. Otherwise DFS may be a better decision.</p>
</details>

# Reference

As a reference I used this [book](https://www.manning.com/books/grokking-algorithms-second-edition).\
For more details on every topic please check it out.
