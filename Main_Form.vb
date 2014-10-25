                    Dim i As Integer = 0
                    For Each obj In list
                        fileContents = fileContents.Replace("<level>" & i & "</level>", "<level>20</level>")
                        i += 1
                    Next