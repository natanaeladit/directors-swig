rm swig -rf
mkdir swig

swig -c++ -csharp \
    -namespace example \
    -outdir ./swig \
    -o ./swig/interop.cpp \
    example.i