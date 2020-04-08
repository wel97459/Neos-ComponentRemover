# Neos-ComponentRemover
A simple example of removing components, in a Slot tree.
It currently only targets LogixReference components.

## Usage
Place the ComponentRemover component at the base slot of the slots you wish it to remove the components from.
The HasRun bool will be set to True if it has run. Clicking the checkbox will make it run the process again.
Just **NOTE** that the Checkbox will always looked checked since this process happens in one frame.
