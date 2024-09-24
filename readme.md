
```
# install diff_cover
pip install diff_cover --user
```

```
git checkout updated

# run tests and generate coverage report
dotnet test --logger:"trx" --results-directory:"./TestResults/" /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput="coverage.xml"

# generate diff coverage report
diff-cover DiffCoverPlayground.UnitTests/coverage.xml --html-report DiffCoverPlayground.UnitTests/report.html --compare-branch main
```