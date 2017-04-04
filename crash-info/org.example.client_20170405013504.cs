S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 29135
Date: 2017-04-05 01:35:04+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 29135, uid 5000)

Register Information
r0   = 0x0000004b, r1   = 0x3f800000
r2   = 0x3f800000, r3   = 0x0000004b
r4   = 0xb3fd9a3c, r5   = 0xbef83484
r6   = 0x00000001, r7   = 0xbef83070
r8   = 0xbef83478, r9   = 0xb8266b90
r10  = 0xbef83498, fp   = 0x00000004
ip   = 0xb5fea120, sp   = 0xbef83050
lr   = 0xb27fc2e9, pc   = 0xb27fd6fe
cpsr = 0x400f0030

Memory Information
MemTotal:   987012 KB
MemFree:     55100 KB
Buffers:     53804 KB
Cached:     280184 KB
VmPeak:     103008 KB
VmSize:     103004 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22344 KB
VmRSS:       22344 KB
VmData:      31364 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35748 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 29135 TID = 29135
29135 29140 29414 29415 

Maps Information
b1084000 b1095000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b10a5000 b10aa000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13a8000 b13b0000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13c2000 b1bc1000 rw-p [stack:29415]
b1bc1000 b1bc2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bd2000 b1be6000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bfa000 b1bfb000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c0b000 b1c0e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c1f000 b1c20000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c30000 b1c32000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c42000 b1c44000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c54000 b1c64000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c74000 b1c80000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c92000 b2491000 rw-p [stack:29414]
b27c2000 b27c9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27dc000 b27e2000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27f2000 b2806000 r-xp /opt/usr/apps/org.example.client/bin/client
b295e000 b2a41000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a78000 b2aa0000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab2000 b32b1000 rw-p [stack:29140]
b32b1000 b32b3000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c3000 b32cd000 r-xp /lib/libnss_files-2.20-2014.11.so
b32de000 b32e7000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32f8000 b3309000 r-xp /lib/libnsl-2.20-2014.11.so
b331c000 b3322000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3333000 b3334000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b335c000 b3363000 r-xp /usr/lib/libminizip.so.1.0.0
b3373000 b3378000 r-xp /usr/lib/libstorage.so.0.1
b3388000 b33e7000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33fd000 b3411000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3421000 b3465000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3475000 b347d000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b348d000 b34bd000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34d0000 b3589000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b359d000 b35f0000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3601000 b361c000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b362c000 b36ed000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3700000 b3710000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3720000 b372d000 r-xp /usr/lib/libmdm-common.so.1.0.98
b373e000 b3745000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3755000 b3796000 r-xp /usr/lib/libmdm.so.1.2.12
b37a6000 b37ae000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37bd000 b37cd000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ee000 b384e000 r-xp /usr/lib/libasound.so.2.0.0
b3860000 b3863000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3873000 b3876000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3886000 b388b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b389b000 b389c000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ac000 b38b7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38cb000 b38d2000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e2000 b38e8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38f8000 b38fd000 r-xp /usr/lib/libmmfsession.so.0.0.1
b390d000 b3928000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3938000 b393f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b394f000 b3952000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3963000 b3991000 r-xp /usr/lib/libidn.so.11.5.44
b39a1000 b39b7000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39c8000 b39d2000 r-xp /usr/lib/libcares.so.2.1.0
b39e2000 b39ec000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39fc000 b39fe000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a0e000 b3a0f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a1f000 b3a23000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a34000 b3a5c000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a6d000 b3a96000 r-xp /usr/lib/libturbojpeg.so
b3ab6000 b3abc000 r-xp /usr/lib/libgif.so.4.1.6
b3acc000 b3b12000 r-xp /usr/lib/libcurl.so.4.3.0
b3b23000 b3b44000 r-xp /usr/lib/libexif.so.12.3.3
b3b5f000 b3b74000 r-xp /usr/lib/libtts.so
b3b85000 b3b8d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b9d000 b3c63000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c83000 b3d7b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d9a000 b3e68000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e7f000 b3e81000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e91000 b3e97000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ea7000 b3eca000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3edb000 b3edd000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eed000 b3eef000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f00000 b3f05000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f1c000 b3f1e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f2e000 b3f35000 r-xp /usr/lib/libsensord-share.so
b3f45000 b3f5d000 r-xp /usr/lib/libsensor.so.1.1.0
b3f6e000 b3f71000 r-xp /usr/lib/libXv.so.1.0.0
b3f81000 b3f86000 r-xp /usr/lib/libutilX.so.1.1.0
b3f96000 b3f9b000 r-xp /usr/lib/libappcore-common.so.1.1
b3fab000 b3fb2000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fc5000 b3fc9000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fda000 b40b8000 r-xp /usr/lib/libCOREGL.so.4.0
b40d8000 b40db000 r-xp /usr/lib/libuuid.so.1.3.0
b40eb000 b4102000 r-xp /usr/lib/libblkid.so.1.1.0
b4113000 b4115000 r-xp /usr/lib/libXau.so.6.0.0
b4125000 b416c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b417e000 b4184000 r-xp /usr/lib/libjson-c.so.2.0.1
b4195000 b4199000 r-xp /usr/lib/libogg.so.0.7.1
b41a9000 b41cb000 r-xp /usr/lib/libvorbis.so.0.4.3
b41db000 b42bf000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42db000 b42de000 r-xp /usr/lib/libEGL.so.1.4
b42ef000 b42f5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4305000 b4307000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4317000 b4324000 r-xp /usr/lib/libGLESv2.so.2.0
b4335000 b4397000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ac000 b43c4000 r-xp /usr/lib/libmount.so.1.1.0
b43d6000 b43ea000 r-xp /usr/lib/libxcb.so.1.1.0
b43fa000 b4401000 r-xp /lib/libcrypt-2.20-2014.11.so
b4439000 b443b000 r-xp /usr/lib/libiri.so
b444b000 b4456000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4467000 b449d000 r-xp /usr/lib/libpulse.so.0.16.2
b44ae000 b44f1000 r-xp /usr/lib/libsndfile.so.1.0.25
b4506000 b451b000 r-xp /lib/libexpat.so.1.5.2
b452d000 b45eb000 r-xp /usr/lib/libcairo.so.2.11200.14
b45ff000 b4607000 r-xp /usr/lib/libdrm.so.2.4.0
b4617000 b461a000 r-xp /usr/lib/libdri2.so.0.0.0
b462a000 b4678000 r-xp /usr/lib/libssl.so.1.0.0
b468d000 b4699000 r-xp /usr/lib/libeeze.so.1.13.0
b46aa000 b46b3000 r-xp /usr/lib/libethumb.so.1.13.0
b46c3000 b46c6000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46d6000 b488d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5678000 b5681000 r-xp /usr/lib/libXi.so.6.1.0
b5691000 b5693000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a3000 b56a7000 r-xp /usr/lib/libXtst.so.6.1.0
b56b7000 b56bd000 r-xp /usr/lib/libXrender.so.1.3.0
b56cd000 b56d3000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e3000 b56e5000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f6000 b56f9000 r-xp /usr/lib/libXfixes.so.3.1.0
b5709000 b5714000 r-xp /usr/lib/libXext.so.6.4.0
b5724000 b5726000 r-xp /usr/lib/libXdamage.so.1.1.0
b5736000 b5738000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5748000 b582a000 r-xp /usr/lib/libX11.so.6.3.0
b583e000 b5845000 r-xp /usr/lib/libXcursor.so.1.0.2
b5855000 b586d000 r-xp /usr/lib/libudev.so.1.6.0
b586f000 b5872000 r-xp /lib/libattr.so.1.1.0
b5882000 b58a2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a3000 b58a8000 r-xp /usr/lib/libffi.so.6.0.2
b58b9000 b58d1000 r-xp /lib/libz.so.1.2.8
b58e1000 b58e3000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f3000 b59c8000 r-xp /usr/lib/libxml2.so.2.9.2
b59dd000 b5a78000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a94000 b5a97000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa7000 b5ac0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad1000 b5ae2000 r-xp /lib/libresolv-2.20-2014.11.so
b5af6000 b5b70000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b85000 b5b87000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b97000 b5b9e000 r-xp /usr/lib/libembryo.so.1.13.0
b5bae000 b5bb8000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bc9000 b5be1000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf2000 b5c15000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c36000 b5c4a000 r-xp /usr/lib/libector.so.1.13.0
b5c5b000 b5c73000 r-xp /usr/lib/liblua-5.1.so
b5c84000 b5cdb000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cef000 b5d17000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d28000 b5d3b000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4c000 b5d86000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d97000 b5da5000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db5000 b5dbd000 r-xp /usr/lib/libtbm.so.1.0.0
b5dcd000 b5dda000 r-xp /usr/lib/libeio.so.1.13.0
b5dea000 b5dec000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dfc000 b5e01000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e11000 b5e28000 r-xp /usr/lib/libefreet.so.1.13.0
b5e3a000 b5e5a000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e6a000 b5e8a000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8c000 b5e92000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea2000 b5eb3000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec4000 b5ecb000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5edb000 b5eea000 r-xp /usr/lib/libeo.so.1.13.0
b5efb000 b5f0d000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f1e000 b5f23000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f33000 b5f4c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5c000 b5f79000 r-xp /usr/lib/libeet.so.1.13.0
b5f92000 b5fda000 r-xp /usr/lib/libeina.so.1.13.0
b5feb000 b5ffb000 r-xp /usr/lib/libefl.so.1.13.0
b600c000 b60f1000 r-xp /usr/lib/libicuuc.so.51.1
b610e000 b624e000 r-xp /usr/lib/libicui18n.so.51.1
b6265000 b629d000 r-xp /usr/lib/libecore_x.so.1.13.0
b62af000 b62b2000 r-xp /lib/libcap.so.2.21
b62c2000 b62eb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62fc000 b6303000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6315000 b634c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b635d000 b6448000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b645b000 b64d4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e6000 b64eb000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64fb000 b6505000 r-xp /usr/lib/libvconf.so.0.2.45
b6515000 b6517000 r-xp /usr/lib/libvasum.so.0.3.1
b6527000 b6529000 r-xp /usr/lib/libttrace.so.1.1
b6539000 b653c000 r-xp /usr/lib/libiniparser.so.0
b654c000 b6572000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6582000 b6587000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6598000 b65af000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c0000 b662b000 r-xp /lib/libm-2.20-2014.11.so
b663c000 b6642000 r-xp /lib/librt-2.20-2014.11.so
b6653000 b6660000 r-xp /usr/lib/libunwind.so.8.0.1
b6696000 b67ba000 r-xp /lib/libc-2.20-2014.11.so
b67cf000 b67e8000 r-xp /lib/libgcc_s-4.9.so.1
b67f8000 b68da000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68eb000 b6915000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6926000 b6962000 r-xp /usr/lib/libsystemd.so.0.4.0
b6964000 b69e7000 r-xp /usr/lib/libedje.so.1.13.0
b69fa000 b6a18000 r-xp /usr/lib/libecore.so.1.13.0
b6a38000 b6bbf000 r-xp /usr/lib/libevas.so.1.13.0
b6bf4000 b6c08000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1c000 b6e50000 r-xp /usr/lib/libelementary.so.1.13.0
b6e7f000 b6e83000 r-xp /usr/lib/libsmack.so.1.0.0
b6e93000 b6e9a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eaa000 b6eac000 r-xp /usr/lib/libdlog.so.0.0.0
b6ebc000 b6ebf000 r-xp /usr/lib/libbundle.so.0.1.22
b6ecf000 b6ed1000 r-xp /lib/libdl-2.20-2014.11.so
b6ee2000 b6efa000 r-xp /usr/lib/libaul.so.0.1.0
b6f0e000 b6f13000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f24000 b6f31000 r-xp /usr/lib/liblptcp.so
b6f43000 b6f47000 r-xp /usr/lib/libsys-assert.so
b6f58000 b6f78000 r-xp /lib/ld-2.20-2014.11.so
b6f89000 b6f8e000 r-xp /usr/bin/launchpad-loader
b8109000 b8447000 rw-p [heap]
bef63000 bef84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29135)
Call Stack Count: 15
 0: _ZN7RootObj13setWeightHintEff + 0x17 (0xb27fd6fe) [/opt/usr/apps/org.example.client/bin/client] + 0xb6fe
 1: _ZN10MyFoodView6drawUIEP9Naviframe + 0x2ac (0xb27fc2e9) [/opt/usr/apps/org.example.client/bin/client] + 0xa2e9
 2: _ZN10MyFoodViewC2EP9Naviframe + 0x58 (0xb27f7c1d) [/opt/usr/apps/org.example.client/bin/client] + 0x5c1d
 3: _ZN7MyLoginC2EP9Naviframe + 0xce (0xb27f6523) [/opt/usr/apps/org.example.client/bin/client] + 0x4523
 4: _ZN8MyWindow8onCreateEv + 0x110 (0xb27f62ad) [/opt/usr/apps/org.example.client/bin/client] + 0x42ad
 5: _ZN6Window10app_createEPv + 0x72 (0xb27fd987) [/opt/usr/apps/org.example.client/bin/client] + 0xb987
 6: _ZN6Window17static_app_createEPv + 0x24 (0xb27fdafd) [/opt/usr/apps/org.example.client/bin/client] + 0xbafd
 7: (0xb3fc74f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 8: appcore_efl_main + 0x152 (0xb6f11203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 9: ui_app_main + 0xc0 (0xb3fc7909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27fde87) [/opt/usr/apps/org.example.client/bin/client] + 0xbe87
11: main + 0x40 (0xb27f6035) [/opt/usr/apps/org.example.client/bin/client] + 0x4035
12: (0xb6f8abb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
13: __libc_start_main + 0x114 (0xb66ac4bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6f8aeb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 01:34:10.879+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-05 01:34:10.879+0900 I/Tizen::App( 1231): (512) > Not registered pid(28558)
04-05 01:34:10.879+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-05 01:34:10.879+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:34:10.879+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 28558
04-05 01:34:10.879+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1573
04-05 01:34:10.889+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:34:10.889+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 28558.
04-05 01:34:11.450+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5800002 FAILED!
04-05 01:34:12.641+0900 E/PKGMGR_SERVER(28899): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:34:12.641+0900 E/PKGMGR_SERVER(28899): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:34:14.193+0900 E/PKGMGR  (28993): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-05 01:34:14.283+0900 E/PKGMGR_SERVER(28995): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:34:14.323+0900 E/PKGMGR_SERVER(28995): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-05 01:34:14.333+0900 E/PKGMGR_SERVER(28995): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-05 01:34:14.333+0900 E/PKGMGR  (28993): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[289930002]
04-05 01:34:14.473+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.473+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-05 01:34:14.473+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.473+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [96]
04-05 01:34:14.483+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-05 01:34:14.483+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.483+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.483+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-05 01:34:14.483+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-05 01:34:14.483+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-05 01:34:14.623+0900 W/CERT_SVC_VCORE(28998): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-05 01:34:14.693+0900 E/rpm-installer(28998): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-05 01:34:14.693+0900 E/rpm-installer(28998): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-05 01:34:14.743+0900 E/PKGMGR_PARSER(28998): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-05 01:34:14.763+0900 I/PRIVACY-MANAGER-CLIENT(28998): SocketClient.cpp: SocketClient(37) > Client created
04-05 01:34:14.763+0900 I/PRIVACY-MANAGER-CLIENT(28998): SocketClient.cpp: connect(62) > Client connected
04-05 01:34:14.763+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-05 01:34:14.763+0900 I/PRIVACY-MANAGER-CLIENT(28998): SocketClient.cpp: disconnect(72) > Client disconnected
04-05 01:34:14.773+0900 E/PKGMGR_CERT(28998): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-05 01:34:14.773+0900 E/PKGMGR_CERT(28998): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-05 01:34:14.783+0900 E/PKGMGR_CERT(28998): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-05 01:34:14.813+0900 E/rpm-installer(28998): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-05 01:34:14.813+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-05 01:34:14.813+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-05 01:34:14.813+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.813+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.813+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-05 01:34:14.823+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-05 01:34:14.823+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-05 01:34:14.823+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-05 01:34:15.364+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-05 01:34:15.364+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-05 01:34:16.475+0900 E/PKGMGR_SERVER(28995): pkgmgr-server.c: sighandler(417) > child NORMAL exit [28998]
04-05 01:34:16.635+0900 E/PKGMGR_SERVER(28995): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:34:16.635+0900 E/PKGMGR_SERVER(28995): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:34:17.346+0900 E/PKGMGR  (29046): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-05 01:34:17.426+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:34:17.476+0900 E/PKGMGR_SERVER(29048): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-05 01:34:17.486+0900 E/PKGMGR_INFO(29048): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-05 01:34:17.486+0900 E/rpm-installer(29048): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-05 01:34:17.496+0900 E/PKGMGR_SERVER(29048): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-05 01:34:17.496+0900 E/PKGMGR  (29046): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[290460002]
04-05 01:34:17.626+0900 E/PKGMGR_INSTALLER(29051): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-05 01:34:17.626+0900 E/rpm-installer(29051): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-05 01:34:17.646+0900 E/rpm-installer(29051): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-05 01:34:17.646+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-05 01:34:17.646+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-05 01:34:17.646+0900 E/rpm-installer(29051): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-05 01:34:17.646+0900 E/rpm-installer(29051): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-05 01:34:17.716+0900 W/CERT_SVC_VCORE(29051): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-05 01:34:17.766+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-05 01:34:17.766+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-05 01:34:17.766+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:17.766+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:17.776+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-05 01:34:17.776+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-05 01:34:17.776+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-05 01:34:17.776+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:17.776+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:17.966+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-05 01:34:17.966+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-05 01:34:17.976+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-05 01:34:17.976+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-05 01:34:17.976+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-05 01:34:17.976+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-05 01:34:17.976+0900 E/PKGMGR_PARSER(29051): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-05 01:34:17.986+0900 E/PKGMGR_PARSER(29051): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-05 01:34:18.016+0900 I/PRIVACY-MANAGER-CLIENT(29051): SocketClient.cpp: SocketClient(37) > Client created
04-05 01:34:18.226+0900 E/PKGMGR_PARSER(29051): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-05 01:34:18.246+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-05 01:34:18.246+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-05 01:34:18.246+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-05 01:34:18.246+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-05 01:34:18.256+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-05 01:34:18.256+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-05 01:34:18.256+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-05 01:34:18.256+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-05 01:34:18.266+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:18.266+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:18.266+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-05 01:34:18.266+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-05 01:34:18.266+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-05 01:34:18.276+0900 E/rpm-installer(29051): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-05 01:34:18.297+0900 E/rpm-installer(29051): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-05 01:34:18.307+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:18.307+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-05 01:34:18.307+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:18.307+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-05 01:34:18.307+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-05 01:34:19.638+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-05 01:34:20.288+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-05 01:34:20.288+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-05 01:34:20.288+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-05 01:34:20.288+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-05 01:34:20.288+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-05 01:34:20.288+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-05 01:34:20.288+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:20.288+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:20.308+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-05 01:34:20.318+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-05 01:34:20.329+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-05 01:34:20.349+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-05 01:34:20.349+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-05 01:34:20.359+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: sighandler(417) > child NORMAL exit [29051]
04-05 01:34:20.359+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-05 01:34:20.359+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-05 01:34:20.359+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-05 01:34:20.359+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-05 01:34:20.359+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-05 01:34:20.359+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-05 01:34:20.359+0900 I/Tizen::App( 1231): (703) > Exit.
04-05 01:34:20.359+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-05 01:34:20.359+0900 I/Tizen::App( 1231): (840) > Enter.
04-05 01:34:20.379+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-05 01:34:20.379+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-05 01:34:20.379+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-05 01:34:20.379+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-05 01:34:20.379+0900 I/Tizen::App( 1231): (131) > Enter
04-05 01:34:20.389+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-05 01:34:20.389+0900 I/Tizen::App( 1231): (883) > Exit.
04-05 01:34:20.389+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-05 01:34:21.640+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:34:21.640+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:34:24.443+0900 W/AUL     (29106): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-05 01:34:24.443+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-05 01:34:24.453+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-05 01:34:24.463+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-05 01:34:24.463+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-05 01:34:24.463+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 29106
04-05 01:34:24.463+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-05 01:34:24.473+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-05 01:34:24.473+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-05 01:34:24.473+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-05 01:34:24.483+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-05 01:34:24.483+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-05 01:34:24.493+0900 I/abc     (28824): abc
04-05 01:34:24.493+0900 I/CAPI_APPFW_APPLICATION(28824): app_main.c: ui_app_main(789) > app_efl_main
04-05 01:34:24.493+0900 I/CAPI_APPFW_APPLICATION(28824): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-05 01:34:24.523+0900 E/TBM     (28824): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-05 01:34:24.583+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 28824, appid: org.example.client
04-05 01:34:24.583+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-05 01:34:24.583+0900 W/AUL     (29106): launch.c: app_request_to_launchpad(425) > request cmd(0) result(28824)
04-05 01:34:24.763+0900 D/basicui (28824): successed to load edc file
04-05 01:34:24.793+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:24.793+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:24.813+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-05 01:34:24.813+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:34:24.823+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:34:24.823+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:34:25.123+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:25.153+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:25.153+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:34:25.173+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-05 01:34:25.173+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:34:25.173+0900 W/CRASH_MANAGER(29122): worker.c: worker_job(1199) > 1128824636c691491323664
04-05 01:34:25.183+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:34:25.574+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-05 01:34:25.574+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-05 01:34:25.614+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 28824 pgid = 28824
04-05 01:34:25.614+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(28824)
04-05 01:34:25.614+0900 E/Tizen::App( 1231): (703) > Cannot acquire app for 28824.
04-05 01:34:25.624+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1584
04-05 01:34:25.654+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-05 01:34:25.654+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-05 01:34:25.654+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-05 01:34:25.654+0900 I/Tizen::App( 1231): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 28824.
04-05 01:34:25.654+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 28824
04-05 01:34:25.654+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 28824
04-05 01:34:25.654+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 28824
04-05 01:34:25.664+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1585
04-05 01:34:26.454+0900 I/UXT     (29135): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-05 01:34:49.557+0900 E/PKGMGR_SERVER(29208): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:34:49.607+0900 E/PKGMGR  (29206): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-05 01:34:49.647+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:34:49.657+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-05 01:34:49.667+0900 E/PKGMGR_SERVER(29208): pkgmgr-server.c: sighandler(417) > child NORMAL exit [29211]
04-05 01:34:51.639+0900 E/PKGMGR_SERVER(29208): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:34:51.639+0900 E/PKGMGR_SERVER(29208): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:34:53.511+0900 E/PKGMGR  (29297): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-05 01:34:53.591+0900 E/PKGMGR_SERVER(29299): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:34:53.631+0900 E/PKGMGR_SERVER(29299): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-05 01:34:53.641+0900 E/PKGMGR_SERVER(29299): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-05 01:34:53.651+0900 E/PKGMGR  (29297): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[292970002]
04-05 01:34:53.801+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:53.801+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-05 01:34:53.801+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:53.801+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-05 01:34:53.801+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-05 01:34:53.811+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-05 01:34:53.811+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-05 01:34:53.811+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-05 01:34:53.811+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:53.811+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:53.961+0900 W/CERT_SVC_VCORE(29302): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-05 01:34:54.031+0900 E/rpm-installer(29302): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-05 01:34:54.031+0900 E/rpm-installer(29302): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-05 01:34:54.081+0900 E/PKGMGR_PARSER(29302): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-05 01:34:54.101+0900 I/PRIVACY-MANAGER-CLIENT(29302): SocketClient.cpp: SocketClient(37) > Client created
04-05 01:34:54.101+0900 I/PRIVACY-MANAGER-CLIENT(29302): SocketClient.cpp: connect(62) > Client connected
04-05 01:34:54.101+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-05 01:34:54.101+0900 I/PRIVACY-MANAGER-CLIENT(29302): SocketClient.cpp: disconnect(72) > Client disconnected
04-05 01:34:54.111+0900 E/PKGMGR_CERT(29302): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-05 01:34:54.111+0900 E/PKGMGR_CERT(29302): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-05 01:34:54.121+0900 E/PKGMGR_CERT(29302): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-05 01:34:54.151+0900 E/rpm-installer(29302): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-05 01:34:54.151+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:54.151+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-05 01:34:54.151+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:54.151+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-05 01:34:54.151+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-05 01:34:54.162+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-05 01:34:54.162+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-05 01:34:54.172+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-05 01:34:54.842+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:34:54.842+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:34:54.842+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:34:54.842+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:34:54.842+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:34:54.842+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:34:54.842+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-05 01:34:54.842+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:34:54.842+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:34:54.842+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:34:54.852+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:34:54.852+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:34:55.643+0900 E/PKGMGR_SERVER(29299): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-05 01:34:55.833+0900 E/PKGMGR_SERVER(29299): pkgmgr-server.c: sighandler(417) > child NORMAL exit [29302]
04-05 01:34:56.674+0900 E/PKGMGR  (29350): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-05 01:34:56.704+0900 E/PKGMGR_SERVER(29299): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-05 01:34:56.714+0900 E/PKGMGR_INFO(29299): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-05 01:34:56.724+0900 E/rpm-installer(29299): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-05 01:34:56.724+0900 E/PKGMGR_SERVER(29299): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-05 01:34:56.734+0900 E/PKGMGR  (29350): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[293500002]
04-05 01:34:56.854+0900 E/PKGMGR_INSTALLER(29352): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-05 01:34:56.854+0900 E/rpm-installer(29352): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-05 01:34:56.864+0900 E/rpm-installer(29352): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-05 01:34:56.864+0900 E/rpm-installer(29352): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-05 01:34:56.864+0900 E/rpm-installer(29352): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-05 01:34:56.864+0900 E/rpm-installer(29352): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-05 01:34:56.864+0900 E/rpm-installer(29352): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-05 01:34:56.914+0900 W/CERT_SVC_VCORE(29352): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-05 01:34:56.964+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-05 01:34:56.964+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-05 01:34:56.974+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:56.974+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:56.984+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-05 01:34:56.984+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-05 01:34:56.984+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-05 01:34:56.984+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:56.984+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:57.164+0900 E/rpm-installer(29352): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-05 01:34:57.164+0900 E/rpm-installer(29352): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-05 01:34:57.164+0900 E/rpm-installer(29352): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-05 01:34:57.164+0900 E/rpm-installer(29352): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-05 01:34:57.164+0900 E/rpm-installer(29352): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-05 01:34:57.164+0900 E/rpm-installer(29352): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-05 01:34:57.174+0900 E/PKGMGR_PARSER(29352): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-05 01:34:57.174+0900 E/PKGMGR_PARSER(29352): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-05 01:34:57.214+0900 I/PRIVACY-MANAGER-CLIENT(29352): SocketClient.cpp: SocketClient(37) > Client created
04-05 01:34:57.435+0900 E/PKGMGR_PARSER(29352): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-05 01:34:57.455+0900 E/PKGMGR_CERT(29352): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-05 01:34:57.455+0900 E/PKGMGR_CERT(29352): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-05 01:34:57.455+0900 E/PKGMGR_CERT(29352): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-05 01:34:57.455+0900 E/PKGMGR_CERT(29352): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-05 01:34:57.455+0900 E/PKGMGR_CERT(29352): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-05 01:34:57.455+0900 E/PKGMGR_CERT(29352): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-05 01:34:57.455+0900 E/PKGMGR_CERT(29352): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-05 01:34:57.455+0900 E/PKGMGR_CERT(29352): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-05 01:34:57.465+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-05 01:34:57.465+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-05 01:34:57.465+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-05 01:34:57.465+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:57.465+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:57.475+0900 E/rpm-installer(29352): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-05 01:34:57.495+0900 E/rpm-installer(29352): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-05 01:34:57.505+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:57.505+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-05 01:34:57.505+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:57.505+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-05 01:34:57.505+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-05 01:34:57.635+0900 E/PKGMGR_SERVER(29299): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-05 01:34:59.467+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-05 01:34:59.467+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-05 01:34:59.467+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-05 01:34:59.467+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:59.467+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:59.477+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-05 01:34:59.477+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-05 01:34:59.477+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-05 01:34:59.527+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-05 01:34:59.547+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-05 01:34:59.557+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-05 01:34:59.567+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-05 01:34:59.567+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-05 01:34:59.567+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-05 01:34:59.567+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-05 01:34:59.567+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-05 01:34:59.577+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-05 01:34:59.577+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-05 01:34:59.577+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-05 01:34:59.577+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-05 01:34:59.577+0900 I/Tizen::App( 1231): (840) > Enter.
04-05 01:34:59.577+0900 I/Tizen::App( 1231): (703) > Exit.
04-05 01:34:59.577+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-05 01:34:59.577+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-05 01:34:59.577+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-05 01:34:59.587+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-05 01:34:59.587+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-05 01:34:59.587+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-05 01:34:59.587+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-05 01:34:59.587+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-05 01:34:59.587+0900 I/Tizen::App( 1231): (131) > Enter
04-05 01:34:59.597+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-05 01:34:59.597+0900 I/Tizen::App( 1231): (883) > Exit.
04-05 01:34:59.597+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-05 01:34:59.627+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-05 01:34:59.637+0900 E/PKGMGR_SERVER(29299): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-05 01:34:59.667+0900 E/PKGMGR_SERVER(29299): pkgmgr-server.c: sighandler(417) > child NORMAL exit [29352]
04-05 01:35:00.648+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-05 01:35:00.658+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:35
04-05 01:35:00.658+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 1:35"
04-05 01:35:00.658+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:35"
04-05 01:35:00.658+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-05 01:35:00.658+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146861077 Time: <font_size=31> </font_size> <font_size=31> 오전 1:35</font_size></font>"
04-05 01:35:01.639+0900 E/PKGMGR_SERVER(29299): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:35:01.639+0900 E/PKGMGR_SERVER(29299): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:35:02.530+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:02.530+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:02.530+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:02.530+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:02.530+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:35:02.530+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:35:02.530+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-05 01:35:02.530+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:02.530+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:02.530+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:02.540+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:35:02.540+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:35:03.761+0900 W/AUL     (29407): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-05 01:35:03.761+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-05 01:35:03.771+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-05 01:35:03.781+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-05 01:35:03.781+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-05 01:35:03.781+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 29407
04-05 01:35:03.781+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-05 01:35:03.791+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-05 01:35:03.791+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-05 01:35:03.791+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-05 01:35:03.791+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-05 01:35:03.791+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-05 01:35:03.811+0900 I/abc     (29135): abc
04-05 01:35:03.811+0900 I/CAPI_APPFW_APPLICATION(29135): app_main.c: ui_app_main(789) > app_efl_main
04-05 01:35:03.811+0900 I/CAPI_APPFW_APPLICATION(29135): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-05 01:35:03.841+0900 E/TBM     (29135): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-05 01:35:03.891+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 29135, appid: org.example.client
04-05 01:35:03.891+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-05 01:35:03.911+0900 W/AUL     (29407): launch.c: app_request_to_launchpad(425) > request cmd(0) result(29135)
04-05 01:35:04.061+0900 D/basicui (29135): successed to load edc file
04-05 01:35:04.091+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:35:04.091+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:35:04.111+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-05 01:35:04.111+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:35:04.121+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:35:04.121+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:35:04.401+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:35:04.442+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:35:04.442+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:35:04.452+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-05 01:35:04.452+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:35:04.472+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:35:04.472+0900 W/CRASH_MANAGER(29422): worker.c: worker_job(1199) > 1129135636c69149132370
