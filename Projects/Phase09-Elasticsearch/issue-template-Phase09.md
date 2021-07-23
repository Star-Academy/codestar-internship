This issue template is based of [Phase09-Elasticsearch.md](./Phase09-Elasticsearch.md) contents.
Click on "Raw" button on right side of this page to see original markdown then create a new issue with original content of this tasklist:


- [ ] Section 1: Read the introduction to Elasticsearch.
    - [ ] Name 3 products of Elastic stack:
        1. `[FILL HERE]`
        1. `[FILL HERE]`
        1. `[FILL HERE]`
- [ ] Section 2: Read architectural benefits and functional features of Elasticsearch.
- [ ] Section 3: Understand concepts of Elasticsearch.
- [ ] Section 4: Install required tools:
    - [ ] Download Elasticsearch.
    - [ ] Download Kibana.
    - [ ] Run Elasticsearch.
    - [ ] Check if Elasticsearch is running opening up [localhost:9200](localhost:9200).
    - [ ] Run Kibana.
    - [ ] Check if Kibana is running opening up [localhost:5601](localhost:5601).
- [ ] Section 5: Create Elasticsearch index:
    - [ ] Open up `Dev Tools` in `Kibana`.
    - [ ] Run create index query.
- [ ] Section 6: Index some documents:
    - [ ] Download `people-simple` dataset.
    - [ ] Index the dataset into the index created in previous section.
    - [ ] Run the query to make sure you've done the job correctly.
- [ ] Section 7: Search queries:
    - [ ] Run `Match` query.
    - [ ] Run `Fuzzy` query.
    - [ ] Write down the difference between `Match` and `Fuzzy` queries:
        - `[Fill Here (feel free to write in Persian)]`
    - [ ] Run `Term` query.
    - [ ] What's the difference between `Match` and `Term` queries?
        - `[Fill Here (feel free to write in Persian)]`
    - [ ] Run `Range` query.
    - [ ] Run `Multi-match` query.
    - [ ] What's the difference between `Match` and `Multi-match`?
        - `[Fill Here (feel free to write in Persian)]`
    - [ ] Run `Bool` queries:
        - [ ] Run 1st bool query.
        - [ ] Run 2nd bool query.
        - [ ] Run 3rd bool query.
    - [ ] Write down a query in which `name` or `last_name` must be 'Mohammadi' with fuzziness of 1 and `name` should be 'Ali' and age should not be more than 30 (**Hint: You can nest bool queries inside each other**)
- [ ] Section 8: Text analysis: Understand concepts introduced in this section
- [ ] Section 9: Text analysis in practice
    - [ ] Get mapping of previously created index and pay attention to the default mapping.
    - [ ] Run analyze API queries:
        - [ ] Run 1st query
        - [ ] Run 2nd query
    - [ ] Create custom analyzer.
    - [ ] Run analyze API query against the custom analyzer.
    - [ ] What can be the usage of this custom analyzer?
        - `[Fill Here (feel free to write in Persian)]`
- [ ] Section 10: Search for substrings
    - [ ] Define mapping for `last_name` field using the custom analyzer.
    - [ ] Run the search query over that field and pay attention to the result.
- [ ] Section 11: Other datatypes
    - [ ] Download `people` dataset.
    - [ ] Create mapping suitable for each field of the dataset.
    - [ ] (Optional but recommended) Try out different search queries over fields of different datatypes.
- [ ] Section 12: Bulk API
    - [ ] Download `poems` dataset.
    - [ ] Index all the data to Elasticsearch at once using the `Bulk` API. Note that you may need to program some code to create the bulk query, because creating it manually is nearly impossible.
- [ ] Section 13: Aggregations
    - [ ] Run the query to get number of poems available from each poet.
    - [ ] (Optional) Read about different kinds of aggregation queries and try them out.
