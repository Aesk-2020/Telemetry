import 'package:aeskapp/classes/theme.dart';
import 'package:aeskapp/custom_widgets/aesk_widgets.dart';
import 'package:aeskapp/custom_widgets/front_inventory.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class Home extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Consumer<MyThemeData>(
      builder: (context, ourTheme, child) {
        return aeskScaffold(
          context: context,
          myBody: Center(
            child: Text((ourTheme.myTheme == DarkTheme()) ? "bu bir karanlık moddur" : "bu aydınlık moddur"),
          ),
        );
      },
    );
  }
}
