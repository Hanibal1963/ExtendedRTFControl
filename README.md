# ExtendedRTF Control

Eine erweiterte RichTextBox mit bequemen Formatierungs- und Abfrage-Hilfen für Auswahl und Caret (u.a. Schriftgröße, Stil-Flags, Vorder-/Hintergrundfarbe, Absatz-Einzüge, Ausrichtung) sowie Batch-Updates über Redraw-Suppression.

## Eigenschaften

- **SelectionFontSize** -   Liest oder setzt die Schriftgröße der aktuellen Auswahl bzw. am Caret.
- **SelectionBold** - Liest oder setzt den Fettdruck der aktuellen Auswahl bzw. am Caret.
- **SelectionItalic** - Liest oder setzt Kursiv (Italic) der aktuellen Auswahl bzw. am Caret.
- **SelectionUnderline** - Liest oder setzt Unterstreichung der aktuellen Auswahl bzw. am Caret.
- **SelectionStrikeout** -  Liest oder setzt Durchstreichung der aktuellen Auswahl bzw. am Caret.
- **SelectionForeColor** - Liest oder setzt die aktuelle Vordergrundfarbe (Textfarbe) der Auswahl bzw. am Caret.
- **SelectionBackColor** - Liest oder setzt die aktuelle Hintergrund-/Highlightfarbe der Auswahl bzw. am Caret.
- **SelectionLeftIndent** - Liest oder setzt den linken Absatz-Einzug (in Pixel) der aktuellen Absatz-/Absatzauswahl bzw. am Caret.

## Methoden

- **ClearFormatting** - Entfernt Formatierungen (Schriftstil, Vorder-/Hintergrundfarbe, Bullet-Aufzählung) vollständig aus aktueller Auswahl oder ohne Auswahl ab der Caret-Position.
- **SetSelectionAlignment** - Setzt die horizontale Ausrichtung der aktuellen Absatz-/Absatzauswahl.
- **ToggleBold** - Schaltet Fettdruck für aktuelle Auswahl bzw. Caret um.
- **ToggleItalic** - Schaltet Kursiv für aktuelle Auswahl bzw. Caret um.
- **ToggleUnderline** - Schaltet Unterstreichung für aktuelle Auswahl bzw. Caret um.
- **ToggleStrikeout** - Schaltet Durchstreichung für aktuelle Auswahl bzw. Caret um.
- **ToggleBullet** - Schaltet Bullet-Aufzählung für aktuelle Absatz-/Absatzauswahl um.  

## Ereignisse

## Versionsinformationen

**1.2026.0507 (07.05.2026)**

- Erste öffentliche Version.