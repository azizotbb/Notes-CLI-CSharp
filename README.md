# Notes CLI - C#

A simple command-line notes application built with C# and Mono.

## Quick Start

1. **Compile the application:**

   ```bash
   mcs src/*.cs -out:bin/notes
   ```

2. **Run the application:**
   ```bash
   mono bin/notes
   ```

## Usage

```bash
# Add a note
mono bin/notes add "Your note text here"

# List all notes
mono bin/notes list

# Search notes
mono bin/notes search "keyword"

# Delete a note by number
mono bin/notes delete 1
```

## Project Structure

```
├── src/           # Source code
├── bin/           # Compiled executable
├── data/          # Notes data file
└── README.md      # This file
```

## Requirements

- Mono runtime
- C# compiler

## Author

[azizotbb](https://github.com/azizotbb)
