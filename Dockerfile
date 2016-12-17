FROM mono
COPY ./ /src
RUN ["xbuild", "/src/Quine.sln"]
CMD ["mono", "/src/Quine/bin/Debug/Quine.exe"]
