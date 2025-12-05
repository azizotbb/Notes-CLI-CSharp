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

3. **Setup shortcut (optional):**

   ```bash
   # Add current directory to PATH for this session
   export PATH=$PATH:$(pwd)

   # Now you can use 'note' from anywhere in this terminal session
   ```

## Usage

### Simple way (after setup):

```bash
# Add a note
note add "Your note text here"

# List all notes
note list

# Search notes
note search "keyword"

# Delete a note by number
note delete 1
```

### Direct way (without setup):

```bash
# Add a note
./note add "Your note text here"

# List all notes
./note list

# Search notes
./note search "keyword"

# Delete a note by number
./note delete 1
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
