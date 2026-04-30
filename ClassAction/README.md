```mermaid
classDiagram

Character <|-- Witch

class Character {
    +string Name
    +int Health
    +int Damage
    +Describe()
    +Attack()
}

class Witch {
    +int Intelligence
}
```