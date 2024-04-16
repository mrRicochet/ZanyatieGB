# Java Development Kit (семинары)

![picture for project](https://www.google.com/search?sca_esv=64f7be2b9ddec3ab&sxsrf=ACQVn08Y_Ejq5jhpZlj7bdwfIPnZK5dBOA:1713279647034&q=%D0%BF%D0%B0%D1%80%D0%B0%D0%B4%D0%BE%D0%BA%D1%81+%D0%BC%D0%BE%D0%BD%D1%82%D0%B8+%D1%85%D0%BE%D0%BB%D0%BB%D0%B0&uds=AMwkrPtfAmBAgAWUkrt1g9jd7WppnPCKff2Mab3UuJk7fxWDRN_ang4lZZUQNvF7mrJFUQBV3PfNt9xy2o760sH70tVGifLnnxJbmFTY7EXr8VWhX3Reg1pxuPf8xlpDXVqc7VutFWM0b0G1f_h9gAPpDBV2Nli8vu_N70WwGOrR1TCuCPNiSE_1kEE1ceFaWjn6A3iM7AfuSxS51clVXeiLUPQxHb75BAHsXAyQihiQIjxDnNVTvMVYaBb9iwAkw3wZV8FwmGl4xWEKf-Jafd9r4sxkoW4nJ3J-dUXt4tE1P49infFE0WjR7ggtaGV9URJjJII3r0ca-_lj0_aULCEgj0bZCiFCUw&udm=2&prmd=ivsnmbt&sa=X&ved=2ahUKEwiorIyGgMeFAxUOR1UIHZkcB_gQtKgLegQIDxAB&biw=1366&bih=584&dpr=1#vhid=QY6naHGpWP_OsM&vssid=mosaic)

## Урок 6. Управление проектом: сборщики проектов


### Задача.

В качестве задачи предлагаю вам реализовать код для демонстрации парадокса Монти Холла ([Парадокс Монти Холла — Википедия](https://ru.wikipedia.org/wiki/Парадокс_Монти_Холла) ) и наглядно убедиться в верности парадокса (запустить игру в цикле на 1000 и вывести итоговый счет).
Необходимо:
Создать свой Java Maven или Gradle проект;
Подключите зависимость lombok и возможно какую то математическую библиотеку (напр. commons-math3);
Самостоятельно реализовать прикладную задачу;
Сохранить результат игр в одну из коллекций или в какой то библиотечный класс;
Вывести на экран статистику по победам и поражениям;
В качестве ответа прислать ссылку на репозиторий, в котором присутствует все важные файлы проекта (напр pom.xml).

#### Решение

Для начала, добавим зависимости в файл pom.xml:

<details>

  <summary>Нажмите, чтобы открыть код</summary>

```xml
<?xml version="1.0" encoding="UTF-8"?>
<project xmlns="http://maven.apache.org/POM/4.0.0"
         xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
         xsi:schemaLocation="http://maven.apache.org/POM/4.0.0 http://maven.apache.org/xsd/maven-4.0.0.xsd">
    <modelVersion>4.0.0</modelVersion>

    <groupId>ru.gb</groupId>
    <artifactId>Seminar6</artifactId>
    <version>1.0-SNAPSHOT</version>

    <properties>
        <maven.compiler.source>21</maven.compiler.source>
        <maven.compiler.target>21</maven.compiler.target>
        <project.build.sourceEncoding>UTF-8</project.build.sourceEncoding>
    </properties>

    <dependencies>
        <dependency>
            <groupId>org.projectlombok</groupId>
            <artifactId>lombok</artifactId>
            <version>1.18.30</version>
            <scope>provided</scope>
        </dependency>
    </dependencies>

</project>
    
```

</details>


Теперь создадим класс MontyHallGame, моделирует игру в парадокс Монти Холла и выводит статистику побед при сохранении или изменении выбора.
Импортируем List для хранения результатов, теперь результаты каждой игры сохраняются в соответствующую коллекцию, и в конце выводится статистика для каждой стратегии (с сохранением и изменением выбора). Импортируем FileWriter для записи результатов в файл на компьютере в текстовый файл. 




<details>

  <summary>Нажмите, чтобы открыть код</summary>

```java
import lombok.AllArgsConstructor;
import lombok.Data;

import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class MontyHallGame {

    @Data
    @AllArgsConstructor
    private static class GameResult {
        private boolean win;
    }

    private static final int NUM_TRIALS = 1000;

    public static void main(String[] args) {
        List<GameResult> resultsWithoutSwitching = new ArrayList<>();
        List<GameResult> resultsWithSwitching = new ArrayList<>();

        for (int i = 0; i < NUM_TRIALS; i++) {
            boolean initialChoice = makeInitialChoice();
            boolean revealedDoor = revealDoor(initialChoice);
            boolean finalChoiceWithoutSwitching = initialChoice;
            boolean finalChoiceWithSwitching = switchDoor(initialChoice, revealedDoor);

            GameResult resultWithoutSwitching = playGame(initialChoice, revealedDoor, finalChoiceWithoutSwitching);
            GameResult resultWithSwitching = playGame(initialChoice, revealedDoor, finalChoiceWithSwitching);

            resultsWithoutSwitching.add(resultWithoutSwitching);
            resultsWithSwitching.add(resultWithSwitching);
        }

        printAndSaveStatistics(resultsWithoutSwitching, "Без смены выбора");
        printAndSaveStatistics(resultsWithSwitching, "Со сменой выбора");
    }

    private static boolean makeInitialChoice() {
        Random random = new Random();
        return random.nextBoolean();
    }

    private static boolean revealDoor(boolean initialChoice) {
        Random random = new Random();
        int revealedDoor = random.nextInt(3);
        while (revealedDoor == (initialChoice ? 1 : 0) || revealedDoor == (initialChoice ? 0 : 1)) {
            revealedDoor = random.nextInt(3);
        }
        return revealedDoor == 1;
    }

    private static boolean switchDoor(boolean initialChoice, boolean revealedDoor) {
        return !initialChoice && !revealedDoor;
    }

    private static GameResult playGame(boolean initialChoice, boolean revealedDoor, boolean finalChoice) {
        return new GameResult(finalChoice && !revealedDoor);
    }

    private static void printAndSaveStatistics(List<GameResult> results, String strategy) {
        long wins = results.stream().filter(GameResult::isWin).count();
        long losses = NUM_TRIALS - wins;

        System.out.println("Стратегия: " + strategy);
        System.out.println("Победы: " + wins);
        System.out.println("Поражения: " + losses);

        // Сохранение результатов в файл локально
        String fileName = "Результаты_игры_" + strategy.replace(" ", "_") + ".txt";
        try (FileWriter writer = new FileWriter(fileName)) {
            for (GameResult result : results) {
                writer.write(result.isWin() ? "Победа" : "Поражение");
                writer.write(System.lineSeparator());
            }
            System.out.println("Результаты для '" + strategy + "' сохранены в файл '" + fileName + "'");
        } catch (IOException e) {
            e.printStackTrace();
        }

        System.out.println();
    }
}
    
```

</details>

Помимо вывода статистики в консоль, результаты также сохраняются в файл (два файла, локально, с соответствующими названиями).


Все работает корректно, согласно задания.