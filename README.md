# ROSY
OSIRiS Recovery System. ROSY is used in the event OSIRiS was not run at sale time.

#What does it do?
ROSY essentially runs the sell portion of OSIRiS but is wrapped up in such a way
that a customer of any skill level should be comfortable.
ROSY is also much lighter than OSIRiS and is single-function thus eliminating
the possibility for error.

#What's with the loose script files?
ROSY compilation has been designed in such a way that the loose script objects are
compiled into to the core ROSY executable. This is in contrast to OSIRiS which uses
a directory structure to hold the files.

The reasoning for this is two fold; OSIRiS has many more complex files and scripts to
house and as such would bloat the executable to a crazy size for such a small application.
ROSY on the other hand needs to be small and portable, so that even customers on mobile
broadband can download it. It also needs to be a minimum of fuss to use and as such has
all of it's components decompressed out of the executable at runtime.
